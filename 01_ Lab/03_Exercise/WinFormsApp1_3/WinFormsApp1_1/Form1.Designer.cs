namespace WinFormsApp1_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCloseForm = new Button();
            SuspendLayout();
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(11, 12);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(75, 23);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "Close Form";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        protected Button btnCloseForm;
        private Button button1;
    }
}
