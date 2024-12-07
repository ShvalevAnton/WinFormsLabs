namespace WinTimer2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlTimer22 = new WindowsFormsControlLibrary1.UserControlTimer2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userControlTimer21 = new WinTimer2.UserControlTimer2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlTimer21);
            this.panel2.Location = new System.Drawing.Point(129, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 72);
            this.panel2.TabIndex = 3;
            // 
            // userControlTimer22
            // 
            this.userControlTimer22.Location = new System.Drawing.Point(38, 46);
            this.userControlTimer22.Name = "userControlTimer22";
            this.userControlTimer22.Size = new System.Drawing.Size(75, 23);
            this.userControlTimer22.TabIndex = 1;
            this.userControlTimer22.Text = "userControlTimer22";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userControlTimer22);
            this.panel1.Location = new System.Drawing.Point(368, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User library";
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(38, 25);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(75, 23);
            this.userControlTimer21.TabIndex = 0;
            this.userControlTimer21.Text = "userControlTimer21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer2 userControlTimer21;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.UserControlTimer2 userControlTimer22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

