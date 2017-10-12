namespace select
{
    partial class FacultyForm
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
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.FacultyInfoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboMethod = new System.Windows.Forms.ComboBox();
            this.FacultyBox = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OfficelLable = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.FacultyInfoBox.SuspendLayout();
            this.FacultyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhotoBox
            // 
            this.PhotoBox.Location = new System.Drawing.Point(32, 44);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(187, 199);
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // FacultyInfoBox
            // 
            this.FacultyInfoBox.Controls.Add(this.TitleLabel);
            this.FacultyInfoBox.Controls.Add(this.OfficelLable);
            this.FacultyInfoBox.Controls.Add(this.PhoneLabel);
            this.FacultyInfoBox.Controls.Add(this.CollegeLabel);
            this.FacultyInfoBox.Controls.Add(this.EmailLabel);
            this.FacultyInfoBox.Location = new System.Drawing.Point(328, 155);
            this.FacultyInfoBox.Name = "FacultyInfoBox";
            this.FacultyInfoBox.Size = new System.Drawing.Size(249, 100);
            this.FacultyInfoBox.TabIndex = 1;
            this.FacultyInfoBox.TabStop = false;
            this.FacultyInfoBox.Text = "Faculty Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Name";
            // 
            // ComboName
            // 
            this.ComboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(122, 36);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(121, 20);
            this.ComboName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Query Method";
            // 
            // ComboMethod
            // 
            this.ComboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMethod.FormattingEnabled = true;
            this.ComboMethod.Location = new System.Drawing.Point(122, 62);
            this.ComboMethod.Name = "ComboMethod";
            this.ComboMethod.Size = new System.Drawing.Size(121, 20);
            this.ComboMethod.TabIndex = 3;
            // 
            // FacultyBox
            // 
            this.FacultyBox.Controls.Add(this.ComboMethod);
            this.FacultyBox.Controls.Add(this.ComboName);
            this.FacultyBox.Controls.Add(this.label2);
            this.FacultyBox.Controls.Add(this.label1);
            this.FacultyBox.Location = new System.Drawing.Point(328, 12);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(269, 101);
            this.FacultyBox.TabIndex = 0;
            this.FacultyBox.TabStop = false;
            this.FacultyBox.Text = "Name and Method";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(46, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 12);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "label3";
            // 
            // OfficelLable
            // 
            this.OfficelLable.AutoSize = true;
            this.OfficelLable.Location = new System.Drawing.Point(46, 31);
            this.OfficelLable.Name = "OfficelLable";
            this.OfficelLable.Size = new System.Drawing.Size(41, 12);
            this.OfficelLable.TabIndex = 1;
            this.OfficelLable.Text = "label4";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(46, 43);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 12);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "label5";
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Location = new System.Drawing.Point(46, 55);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(41, 12);
            this.CollegeLabel.TabIndex = 3;
            this.CollegeLabel.Text = "label6";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(46, 76);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 12);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "label7";
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(61, 298);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(75, 23);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.UseVisualStyleBackColor = true;
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(182, 298);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(75, 23);
            this.cmdInsert.TabIndex = 3;
            this.cmdInsert.Text = "Insert";
            this.cmdInsert.UseVisualStyleBackColor = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(312, 298);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(450, 298);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(566, 298);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 6;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            // 
            // FacultyForm
            // 
            this.AcceptButton = this.cmdSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 333);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.FacultyBox);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.FacultyInfoBox);
            this.Controls.Add(this.PhotoBox);
            this.Name = "FacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSE DEPT Faculty Form";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.FacultyInfoBox.ResumeLayout(false);
            this.FacultyInfoBox.PerformLayout();
            this.FacultyBox.ResumeLayout(false);
            this.FacultyBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.GroupBox FacultyInfoBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label OfficelLable;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboMethod;
        private System.Windows.Forms.GroupBox FacultyBox;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdBack;
    }
}