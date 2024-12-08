namespace CalculateSine
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
            this.lblIntervalSine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbListSine = new System.Windows.Forms.RichTextBox();
            this.btnSetInterval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntervalSine
            // 
            this.lblIntervalSine.AutoSize = true;
            this.lblIntervalSine.Location = new System.Drawing.Point(101, 71);
            this.lblIntervalSine.Name = "lblIntervalSine";
            this.lblIntervalSine.Size = new System.Drawing.Size(79, 13);
            this.lblIntervalSine.TabIndex = 0;
            this.lblIntervalSine.Text = ",,,,,,,,,,,,,,,,,,,,,,,,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значение функции sin(x) на интервале:";
            // 
            // rtbListSine
            // 
            this.rtbListSine.Location = new System.Drawing.Point(104, 115);
            this.rtbListSine.Name = "rtbListSine";
            this.rtbListSine.ReadOnly = true;
            this.rtbListSine.Size = new System.Drawing.Size(199, 190);
            this.rtbListSine.TabIndex = 2;
            this.rtbListSine.Text = "";
            // 
            // btnSetInterval
            // 
            this.btnSetInterval.Location = new System.Drawing.Point(365, 115);
            this.btnSetInterval.Name = "btnSetInterval";
            this.btnSetInterval.Size = new System.Drawing.Size(104, 55);
            this.btnSetInterval.TabIndex = 3;
            this.btnSetInterval.Text = "Задать интервал";
            this.btnSetInterval.UseVisualStyleBackColor = true;
            this.btnSetInterval.Click += new System.EventHandler(this.btnSetInterval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 360);
            this.Controls.Add(this.btnSetInterval);
            this.Controls.Add(this.rtbListSine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIntervalSine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sin(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntervalSine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbListSine;
        private System.Windows.Forms.Button btnSetInterval;
    }
}

