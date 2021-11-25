using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{
    public partial class Form5 : Form
    {
        public bool IsEditorFlag { get; set; }

        public Form5()
        {
            InitializeComponent();
        }
        public Form5(bool isEditorFlag)
        {
            InitializeComponent();
            IsEditorFlag = isEditorFlag;
        }
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2(IsEditorFlag)).Show();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(ControlsValidation.ValidateAllFieldFilled(FirstNameTextBox, LastNameTextBox, AddressTextBox, DateOfBirthTextBox, SoATextBox, PositionTextBox) == true)
            {
                if (ControlsValidation.ValidateDate(DateOfBirthTextBox) ==true && ControlsValidation.ValidateDate(SoATextBox) == true)
                {
                    string pathToPicture = labelPathToPicure.Text;
                    byte[] content = null;
                    if (pathToPicture != "Path to photo")
                    {
                        content = File.ReadAllBytes(pathToPicture);
                    }
                    int licznikID = DatabaseConnection.FindHighestIDinTableEmployees();
                    string stSql = "insert into TableEmployees (id, FirstName, LastName, Address, DateOfBirth, StartOfAssignment, EmployeePos, Image)values ('" + licznikID.ToString() + "','" + FirstNameTextBox.Text + "','" + LastNameTextBox.Text + "','" + AddressTextBox.Text + "','" + DateOfBirthTextBox.Text + "','" + SoATextBox.Text + "','" + PositionTextBox.Text + "', @photo)";
                    DatabaseConnection.InsertNewEmployeeToTableEmployees(licznikID, content, stSql);
                    MessageBox.Show("new Person added successfully");
                    FirstNameTextBox.Text = "";
                    LastNameTextBox.Text = "";
                    AddressTextBox.Text = "";
                    DateOfBirthTextBox.Text = "";
                    SoATextBox.Text = "";
                    PositionTextBox.Text = "";
                    pictureBox1.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select input jpg file";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelPathToPicure.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
