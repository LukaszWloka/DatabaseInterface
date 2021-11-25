
namespace DatabaseInterface
{
    partial class Form2
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
            this.EmplOverviewButton = new System.Windows.Forms.Button();
            this.EmplAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmplOverviewButton
            // 
            this.EmplOverviewButton.Location = new System.Drawing.Point(57, 45);
            this.EmplOverviewButton.Name = "EmplOverviewButton";
            this.EmplOverviewButton.Size = new System.Drawing.Size(183, 52);
            this.EmplOverviewButton.TabIndex = 0;
            this.EmplOverviewButton.Text = "View existing employees";
            this.EmplOverviewButton.UseVisualStyleBackColor = true;
            this.EmplOverviewButton.Click += new System.EventHandler(this.EmplOverviewButton_Click);
            // 
            // EmplAddButton
            // 
            this.EmplAddButton.Location = new System.Drawing.Point(57, 139);
            this.EmplAddButton.Name = "EmplAddButton";
            this.EmplAddButton.Size = new System.Drawing.Size(177, 50);
            this.EmplAddButton.TabIndex = 2;
            this.EmplAddButton.Text = "Add new Employee";
            this.EmplAddButton.UseVisualStyleBackColor = true;
            this.EmplAddButton.Click += new System.EventHandler(this.EmplAddButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 250);
            this.Controls.Add(this.EmplAddButton);
            this.Controls.Add(this.EmplOverviewButton);
            this.Name = "Form2";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmplOverviewButton;
        private System.Windows.Forms.Button EmplAddButton;
    }
}