namespace FileManager.Presentation.WinSite
{
    partial class formStudent
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
            this.btnSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxFileFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelStudentDni = new System.Windows.Forms.Label();
            this.textBoxStudentDni = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.pickerAgeOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 26);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxFileFormat
            // 
            this.comboBoxFileFormat.FormattingEnabled = true;
            this.comboBoxFileFormat.Items.AddRange(new object[] {
            "JSON",
            "XML"});
            this.comboBoxFileFormat.Location = new System.Drawing.Point(249, 245);
            this.comboBoxFileFormat.Name = "comboBoxFileFormat";
            this.comboBoxFileFormat.Size = new System.Drawing.Size(102, 28);
            this.comboBoxFileFormat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Format";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(46, 143);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Surname";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(126, 143);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(225, 26);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelStudentDni
            // 
            this.labelStudentDni.AutoSize = true;
            this.labelStudentDni.Location = new System.Drawing.Point(46, 48);
            this.labelStudentDni.Name = "labelStudentDni";
            this.labelStudentDni.Size = new System.Drawing.Size(98, 20);
            this.labelStudentDni.TabIndex = 7;
            this.labelStudentDni.Text = "Student DNI";
            // 
            // textBoxStudentDni
            // 
            this.textBoxStudentDni.Location = new System.Drawing.Point(150, 45);
            this.textBoxStudentDni.Name = "textBoxStudentDni";
            this.textBoxStudentDni.Size = new System.Drawing.Size(201, 26);
            this.textBoxStudentDni.TabIndex = 1;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(46, 194);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(97, 20);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of birth";
            // 
            // pickerAgeOfBirth
            // 
            this.pickerAgeOfBirth.Location = new System.Drawing.Point(151, 190);
            this.pickerAgeOfBirth.Name = "pickerAgeOfBirth";
            this.pickerAgeOfBirth.Size = new System.Drawing.Size(200, 26);
            this.pickerAgeOfBirth.TabIndex = 4;
            this.pickerAgeOfBirth.Value = new System.DateTime(2020, 3, 2, 0, 0, 0, 0);
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pickerAgeOfBirth);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxStudentDni);
            this.Controls.Add(this.labelStudentDni);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFileFormat);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnSave);
            this.Name = "formStudent";
            this.Text = "STUDENT REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxFileFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelStudentDni;
        private System.Windows.Forms.TextBox textBoxStudentDni;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker pickerAgeOfBirth;
    }
}

