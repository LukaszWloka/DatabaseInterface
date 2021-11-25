
namespace DatabaseInterface
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmplListdataGridView = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.labelPathToPicure = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.SoATextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePositionLabel = new System.Windows.Forms.Label();
            this.StartOfAssignmentLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ImportToXMLButton = new System.Windows.Forms.Button();
            this.ExportFromXMLButton = new System.Windows.Forms.Button();
            this.iDLabel = new System.Windows.Forms.Label();
            this.IDValueLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangePictureButton = new System.Windows.Forms.Button();
            this.ExportFromCSVButton = new System.Windows.Forms.Button();
            this.ImportToCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmplListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmplListdataGridView
            // 
            this.EmplListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmplListdataGridView.Location = new System.Drawing.Point(12, 83);
            this.EmplListdataGridView.Name = "EmplListdataGridView";
            this.EmplListdataGridView.Size = new System.Drawing.Size(899, 256);
            this.EmplListdataGridView.TabIndex = 0;
            this.EmplListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmplListdataGridView_CellClick);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(315, 22);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(170, 43);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show list of Employees";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // labelPathToPicure
            // 
            this.labelPathToPicure.AutoSize = true;
            this.labelPathToPicure.Location = new System.Drawing.Point(337, 642);
            this.labelPathToPicure.Name = "labelPathToPicure";
            this.labelPathToPicure.Size = new System.Drawing.Size(140, 13);
            this.labelPathToPicure.TabIndex = 2;
            this.labelPathToPicure.Text = "Path To new updated photo";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(166, 575);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(151, 20);
            this.PositionTextBox.TabIndex = 24;
            // 
            // SoATextBox
            // 
            this.SoATextBox.Location = new System.Drawing.Point(166, 538);
            this.SoATextBox.Name = "SoATextBox";
            this.SoATextBox.Size = new System.Drawing.Size(151, 20);
            this.SoATextBox.TabIndex = 23;
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(166, 503);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(151, 20);
            this.DateOfBirthTextBox.TabIndex = 22;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(166, 467);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(151, 20);
            this.AddressTextBox.TabIndex = 21;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(166, 431);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(166, 397);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.FirstNameTextBox.TabIndex = 19;
            // 
            // EmployeePositionLabel
            // 
            this.EmployeePositionLabel.AutoSize = true;
            this.EmployeePositionLabel.Location = new System.Drawing.Point(53, 582);
            this.EmployeePositionLabel.Name = "EmployeePositionLabel";
            this.EmployeePositionLabel.Size = new System.Drawing.Size(93, 13);
            this.EmployeePositionLabel.TabIndex = 18;
            this.EmployeePositionLabel.Text = "Employee Position";
            // 
            // StartOfAssignmentLabel
            // 
            this.StartOfAssignmentLabel.AutoSize = true;
            this.StartOfAssignmentLabel.Location = new System.Drawing.Point(53, 545);
            this.StartOfAssignmentLabel.Name = "StartOfAssignmentLabel";
            this.StartOfAssignmentLabel.Size = new System.Drawing.Size(103, 13);
            this.StartOfAssignmentLabel.TabIndex = 17;
            this.StartOfAssignmentLabel.Text = "Start Of Assignment ";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(52, 510);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.DateOfBirthLabel.TabIndex = 16;
            this.DateOfBirthLabel.Text = "Date Of Birth";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(52, 474);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 15;
            this.AddressLabel.Text = "Address";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(52, 438);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(53, 400);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "First Name";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateButton.Location = new System.Drawing.Point(628, 599);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(130, 28);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Update Employee";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.DeleteButton.Location = new System.Drawing.Point(780, 597);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(131, 32);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "DELETE Employee";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ImportToXMLButton
            // 
            this.ImportToXMLButton.Location = new System.Drawing.Point(780, 361);
            this.ImportToXMLButton.Name = "ImportToXMLButton";
            this.ImportToXMLButton.Size = new System.Drawing.Size(132, 36);
            this.ImportToXMLButton.TabIndex = 27;
            this.ImportToXMLButton.Text = "Export selection to XML file";
            this.ImportToXMLButton.UseVisualStyleBackColor = true;
            this.ImportToXMLButton.Click += new System.EventHandler(this.ImportToXMLButton_Click);
            // 
            // ExportFromXMLButton
            // 
            this.ExportFromXMLButton.Location = new System.Drawing.Point(628, 361);
            this.ExportFromXMLButton.Name = "ExportFromXMLButton";
            this.ExportFromXMLButton.Size = new System.Drawing.Size(131, 36);
            this.ExportFromXMLButton.TabIndex = 28;
            this.ExportFromXMLButton.Text = "Import From XML file";
            this.ExportFromXMLButton.UseVisualStyleBackColor = true;
            this.ExportFromXMLButton.Click += new System.EventHandler(this.ExportFromXMLButton_Click);
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Location = new System.Drawing.Point(50, 367);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(18, 13);
            this.iDLabel.TabIndex = 29;
            this.iDLabel.Text = "ID";
            // 
            // IDValueLabel
            // 
            this.IDValueLabel.AutoSize = true;
            this.IDValueLabel.Location = new System.Drawing.Point(164, 367);
            this.IDValueLabel.Name = "IDValueLabel";
            this.IDValueLabel.Size = new System.Drawing.Size(0, 13);
            this.IDValueLabel.TabIndex = 30;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 37);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(98, 13);
            this.FilterLabel.TabIndex = 31;
            this.FilterLabel.Text = "Filter by last Names";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(132, 34);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(140, 20);
            this.FilterTextBox.TabIndex = 32;
            this.FilterTextBox.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(335, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 194);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePictureButton
            // 
            this.ChangePictureButton.Location = new System.Drawing.Point(335, 597);
            this.ChangePictureButton.Name = "ChangePictureButton";
            this.ChangePictureButton.Size = new System.Drawing.Size(142, 33);
            this.ChangePictureButton.TabIndex = 34;
            this.ChangePictureButton.Text = "Change Picture";
            this.ChangePictureButton.UseVisualStyleBackColor = true;
            this.ChangePictureButton.Click += new System.EventHandler(this.ChangePictureButton_Click);
            // 
            // ExportFromCSVButton
            // 
            this.ExportFromCSVButton.Location = new System.Drawing.Point(628, 416);
            this.ExportFromCSVButton.Name = "ExportFromCSVButton";
            this.ExportFromCSVButton.Size = new System.Drawing.Size(130, 35);
            this.ExportFromCSVButton.TabIndex = 35;
            this.ExportFromCSVButton.Text = "Import From CSV";
            this.ExportFromCSVButton.UseVisualStyleBackColor = true;
            this.ExportFromCSVButton.Click += new System.EventHandler(this.ExportFromCSVButton_Click);
            // 
            // ImportToCSVButton
            // 
            this.ImportToCSVButton.Location = new System.Drawing.Point(780, 416);
            this.ImportToCSVButton.Name = "ImportToCSVButton";
            this.ImportToCSVButton.Size = new System.Drawing.Size(131, 34);
            this.ImportToCSVButton.TabIndex = 36;
            this.ImportToCSVButton.Text = "Export selection  to CSV file";
            this.ImportToCSVButton.UseVisualStyleBackColor = true;
            this.ImportToCSVButton.Click += new System.EventHandler(this.ImportToCSVButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 664);
            this.Controls.Add(this.ImportToCSVButton);
            this.Controls.Add(this.ExportFromCSVButton);
            this.Controls.Add(this.ChangePictureButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.IDValueLabel);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.ExportFromXMLButton);
            this.Controls.Add(this.ImportToXMLButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.SoATextBox);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmployeePositionLabel);
            this.Controls.Add(this.StartOfAssignmentLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.labelPathToPicure);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.EmplListdataGridView);
            this.Name = "Form3";
            this.Text = "employee view";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EmplListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmplListdataGridView;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label labelPathToPicure;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox SoATextBox;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label EmployeePositionLabel;
        private System.Windows.Forms.Label StartOfAssignmentLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ImportToXMLButton;
        private System.Windows.Forms.Button ExportFromXMLButton;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label IDValueLabel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChangePictureButton;
        private System.Windows.Forms.Button ExportFromCSVButton;
        private System.Windows.Forms.Button ImportToCSVButton;
    }
}