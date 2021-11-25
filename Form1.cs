using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{

    public partial class Form1 : Form
    {
        public class TableOfOperators
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserLogin { get; set; }
            public string UserPassword { get; set; }
            public string Status { get; set; }
        }
        List<TableOfOperators> listOfOperators = new List<TableOfOperators>();
        bool LoginFlag;
        bool IsEditorFlag;
        public Form1()
        {
            InitializeComponent();
            FbConnection fbConnection = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            FbDataReader myReader = null;
            string sql = "Select * from TableUsers";
            FbCommand myCommand = new FbCommand(sql, fbConnection);
            fbConnection.Open();
            myCommand.CommandTimeout = 0;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfOperators.Add(new TableOfOperators { Id = myReader["id"].ToString(), FirstName = myReader["FirstName"].ToString(), LastName = myReader["LastName"].ToString(), UserLogin = myReader["UserLogin"].ToString(), UserPassword = myReader["UserPassword"].ToString(), Status = myReader["Status"].ToString() });
            }
            fbConnection.Close();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            foreach (TableOfOperators oneRecord in listOfOperators)
            {
                if (oneRecord.UserLogin == LoginTextBox.Text & oneRecord.UserPassword == PasswordTextbox.Text)
                {
                    if(oneRecord.Status == "editor")
                    {
                        IsEditorFlag = true;
                    }
                    LoginFlag = true;
                    this.Close();
                }
            }
            if(LoginFlag == false)
            {
                MessageBox.Show("login failed for user " + LoginTextBox.Text);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginFlag == true)
            {
                (new Form2(IsEditorFlag)).Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
