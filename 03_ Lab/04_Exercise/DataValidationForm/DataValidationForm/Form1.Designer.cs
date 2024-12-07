namespace DataValidationForm
{
    partial class Form1
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
            this.dataValidationForm1 = new WindowsFormsControlLibrary1.DataValidationForm();
            this.SuspendLayout();
            // 
            // dataValidationForm1
            // 
            this.dataValidationForm1.Location = new System.Drawing.Point(25, 24);
            this.dataValidationForm1.Name = "dataValidationForm1";
            this.dataValidationForm1.Size = new System.Drawing.Size(409, 193);
            this.dataValidationForm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 264);
            this.Controls.Add(this.dataValidationForm1);
            this.Name = "Form1";
            this.Text = "Форма валидации данных";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.DataValidationForm dataValidationForm1;
    }
}

