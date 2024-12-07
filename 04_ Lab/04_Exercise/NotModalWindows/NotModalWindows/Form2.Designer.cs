namespace NotModalWindows
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
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(192, 48);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(100, 20);
            this.textBoxF21.TabIndex = 0;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(506, 48);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(100, 20);
            this.textBoxF23.TabIndex = 1;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(346, 48);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(100, 20);
            this.textBoxF22.TabIndex = 2;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(45, 45);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(100, 23);
            this.btnPass.TabIndex = 3;
            this.btnPass.Text = "button1";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 127);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF21);
            this.Name = "Form2";
            this.Text = "Вторая форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF21;
        private System.Windows.Forms.TextBox textBoxF23;
        private System.Windows.Forms.TextBox textBoxF22;
        private System.Windows.Forms.Button btnPass;
    }
}