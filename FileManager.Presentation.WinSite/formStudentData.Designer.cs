namespace FileManager.Presentation.WinSite
{
    partial class formStudentData
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
            this.btnTxtFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTxtFormat
            // 
            this.btnTxtFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTxtFormat.Location = new System.Drawing.Point(48, 176);
            this.btnTxtFormat.Name = "btnTxtFormat";
            this.btnTxtFormat.Size = new System.Drawing.Size(178, 75);
            this.btnTxtFormat.TabIndex = 0;
            this.btnTxtFormat.Text = "TXT DATA";
            this.btnTxtFormat.UseVisualStyleBackColor = true;
            this.btnTxtFormat.Click += new System.EventHandler(this.btnTxtFormat_Click);
            // 
            // formStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTxtFormat);
            this.Name = "formStudentData";
            this.Text = "Student Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTxtFormat;
    }
}

