using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseInterface
{
    public partial class Form3 : Form
    {
        string lastNameFilter;
        public bool IsEditorFlag { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(bool isEditorFlag)
        {
            InitializeComponent();
            IsEditorFlag = isEditorFlag;
            if(IsEditorFlag ==false)
            {
                ExportFromXMLButton.Visible = false;
                ImportToXMLButton.Visible = false;
                ExportFromCSVButton.Visible = false;
                ImportToCSVButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
                ChangePictureButton.Visible = false;
                labelPathToPicure.Visible = false;
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2(IsEditorFlag)).Show();
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            lastNameFilter = FilterTextBox.Text;
            if (lastNameFilter == null)
            {
                lastNameFilter = "%";
            }
            EmplListdataGridView.DataSource = DatabaseConnection.SelectFromTableEmployeesByLastName(lastNameFilter);
        }
        private void EmplListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.EmplListdataGridView.Rows[e.RowIndex];
                    IDValueLabel.Text = row.Cells[0].Value.ToString();
                    FirstNameTextBox.Text = row.Cells[1].Value.ToString();
                    LastNameTextBox.Text = row.Cells[2].Value.ToString();
                    AddressTextBox.Text = row.Cells[3].Value.ToString();
                    DateOfBirthTextBox.Text = row.Cells[4].Value.ToString().Substring(0, row.Cells[4].Value.ToString().LastIndexOf('/') + 5);
                    SoATextBox.Text = row.Cells[5].Value.ToString().Substring(0, row.Cells[5].Value.ToString().LastIndexOf('/') + 5);
                    PositionTextBox.Text = row.Cells[6].Value.ToString();
                    if (row.Cells[7].Value.ToString() != "")
                    {
                        using (var ms = new MemoryStream((byte[])row.Cells[7].Value))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                IDValueLabel.Text = "";
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                AddressTextBox.Text = "";
                DateOfBirthTextBox.Text = "";
                SoATextBox.Text = "";
                PositionTextBox.Text = "";
                pictureBox1.Image = null;
            }

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string pathToPicture;
            byte[] content;
            if (labelPathToPicure.Text != "Path To new updated photo")
            {
                pathToPicture = labelPathToPicure.Text;
                content = File.ReadAllBytes(pathToPicture);
            }
            else
            {
                content = null;
            }
            string stSql = "UPDATE TableEmployees SET FirstName ='" + FirstNameTextBox.Text + "', LastName = '" + LastNameTextBox.Text + "', Address = '" + AddressTextBox.Text + "', DateOfBirth = '" + DateOfBirthTextBox.Text + "', StartOfAssignment ='" + SoATextBox.Text + "', EmployeePos ='" + PositionTextBox.Text + "', Image = @photo WHERE id = '" + IDValueLabel.Text + "'";
            DatabaseConnection.UpdateRecordInTableEmployees(content, stSql);
            lastNameFilter = FilterTextBox.Text;
            if (lastNameFilter == null)
            {
                lastNameFilter = "%";
            }
            EmplListdataGridView.DataSource = DatabaseConnection.SelectFromTableEmployeesByLastName(lastNameFilter);
            labelPathToPicure.Text = "Path To new updated photo";

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string stSql = "DELETE FROM TableEmployees WHERE id = '" + IDValueLabel.Text + "'";
            DatabaseConnection.DeleteRecordFromTableEmployees(stSql);
            lastNameFilter = FilterTextBox.Text;
            if (lastNameFilter == null)
            {
                lastNameFilter = "%";
            }
            EmplListdataGridView.DataSource = DatabaseConnection.SelectFromTableEmployeesByLastName(lastNameFilter);
        }

        private void ExportFromXMLButton_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, Address, DateOfBirth, StartOfAssignment, EmployeePos;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select input XML file";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                XDocument doc = XDocument.Load(filePath);
                foreach (XElement SingleEmployee in doc.Descendants("Pracownicy").Elements("Pracownik"))
                {
                    FirstName = SingleEmployee.Element("FirstName").Value.ToString();
                    LastName = SingleEmployee.Element("LastName").Value.ToString();
                    Address = SingleEmployee.Element("Address").Value.ToString();
                    DateOfBirth = SingleEmployee.Element("DateOfBirth").Value.ToString();
                    StartOfAssignment = SingleEmployee.Element("StartOfAssignment").Value.ToString();
                    EmployeePos = SingleEmployee.Element("EmployeePos").Value.ToString();
                    int licznikID;
                    licznikID = DatabaseConnection.FindHighestIDinTableEmployees();
                    string stSql = "insert into TableEmployees (id, FirstName, LastName, Address, DateOfBirth, StartOfAssignment, EmployeePos)values ('" + licznikID.ToString() + "','" + FirstName + "','" + LastName + "','" + Address + "','" + DateOfBirth + "','" + StartOfAssignment + "','" + EmployeePos + "')";
                    DatabaseConnection.InsertNewEmployeeToTableEmployees(licznikID, null, stSql);
                }
            }
        }
        private void ImportToXMLButton_Click(object sender, EventArgs e)
        {
            lastNameFilter = FilterTextBox.Text;
            string filter = lastNameFilter.Replace('%','*');
            FbConnection fbConnection = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            XDocument XMLdocumentToCheck = new XDocument(new XElement("Pracownicy"));
            FbDataReader myReader;
            string sql = "Select "+ filter + " from TableEmployees";
            FbCommand myCommand = new FbCommand(sql, fbConnection);
            fbConnection.Open();
            myCommand.CommandTimeout = 0;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                XMLdocumentToCheck.Root.Add(new XElement("Pracownik", new XElement("id", myReader["id"].ToString()), new XElement("FirstName", myReader["FirstName"].ToString()), new XElement("LastName", myReader["LastName"].ToString()), new XElement("Address", myReader["Address"].ToString()), new XElement("DateOfBirth", myReader["DateOfBirth"].ToString()), new XElement("StartOfAssignment", myReader["StartOfAssignment"].ToString()), new XElement("EmployeePos", myReader["EmployeePos"].ToString())));
            }
            fbConnection.Close();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save to XML File";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XMLdocumentToCheck.Save(saveFileDialog1.FileName);
            }
        }
        private void ChangePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select input jpg file";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelPathToPicure.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ExportFromCSVButton_Click(object sender, EventArgs e)
        {
            string FirstName, LastName, Address, DateOfBirth, StartOfAssignment, EmployeePos;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select input CSV file";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "xml files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string[] allLinesFromCSVFile = File.ReadAllLines(filePath);
                for (int x = 1; x < allLinesFromCSVFile.Length; x++)
                {
                    string singleLine = allLinesFromCSVFile[x];
                    string[] delimitedLine = singleLine.Split(',');
                    FirstName = delimitedLine[0];
                    LastName = delimitedLine[1];
                    Address = delimitedLine[2];
                    DateOfBirth = delimitedLine[3];
                    StartOfAssignment = delimitedLine[4];
                    EmployeePos = delimitedLine[5];
                    int licznikID = DatabaseConnection.FindHighestIDinTableEmployees();
                    string stSql = "insert into TableEmployees (id, FirstName, LastName, Address, DateOfBirth, StartOfAssignment, EmployeePos)values ('" + licznikID.ToString() + "','" + FirstName + "','" + LastName + "','" + Address + "','" + DateOfBirth + "','" + StartOfAssignment + "','" + EmployeePos + "')";
                    DatabaseConnection.InsertNewEmployeeToTableEmployees(licznikID, null, stSql);
                }
            }
        }
        private void ImportToCSVButton_Click(object sender, EventArgs e)
        {
            lastNameFilter = FilterTextBox.Text;
            string filter = lastNameFilter.Replace('%', '*');
            List<TableEmployeesModel> listOfEmployees = new List<TableEmployeesModel>();
            string CSVstring = "";
            string singleCSVline;
            FbConnection fbConnection = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            FbDataReader myReader = null;
            string sql = "Select "+ filter + " from TableEmployees";
            FbCommand myCommand = new FbCommand(sql, fbConnection);
            fbConnection.Open();
            myCommand.CommandTimeout = 0;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfEmployees.Add(new TableEmployeesModel { id= myReader["id"].ToString(), FirstName = myReader["FirstName"].ToString(), LastName = myReader["LastName"].ToString(), Address = myReader["Address"].ToString(), DateOfBirth = myReader["DateOfBirth"].ToString(), StartOfAssignment = myReader["StartOfAssignment"].ToString(), EmployeePos = myReader["EmployeePos"].ToString() });
            }
            fbConnection.Close();
            foreach(TableEmployeesModel singleLine in listOfEmployees)
            {
                singleCSVline = singleLine.id + "," + singleLine.FirstName + "," + singleLine.LastName + "," + singleLine.Address + "," + singleLine.DateOfBirth + "," + singleLine.StartOfAssignment + "," + singleLine.EmployeePos;
                CSVstring = CSVstring + singleCSVline + System.Environment.NewLine;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save to CSV File";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, CSVstring);
            }
        }
    }
}