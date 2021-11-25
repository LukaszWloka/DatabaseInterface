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
    public partial class Form2 : Form
    {
        public bool IsEditorFlag { get; set; }
        public string FunctionalityChoice;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(bool isEditorFlag)
        {
            InitializeComponent();
            IsEditorFlag = isEditorFlag;
            if (IsEditorFlag == false)
            {
                EmplAddButton.Visible = false;
            }
        }
        private void EmplOverviewButton_Click(object sender, EventArgs e)
        {
            FunctionalityChoice = "1";
            this.Close();
        }
        private void EmplAddButton_Click(object sender, EventArgs e)
        {
            FunctionalityChoice = "2";
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch(FunctionalityChoice)
            {
                case "1":
                    {
                        (new Form3(IsEditorFlag)).Show();
                        break;
                    }
                case "2":
                    {
                        (new Form5(IsEditorFlag)).Show();
                        break;
                    }
                default:
                    {
                        Application.Exit();
                        break;
                    }
            }
        }
    }
}