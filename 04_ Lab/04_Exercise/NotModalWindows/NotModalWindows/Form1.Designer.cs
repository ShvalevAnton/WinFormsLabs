namespace NotModalWindows
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
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(188, 31);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(100, 20);
            this.textBoxF1.TabIndex = 1;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(44, 31);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(100, 23);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "button1";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 159);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.textBoxF1);
            this.Name = "Form1";
            this.Text = "Первая форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.Button btnTake;
    }
}

