namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            btnBorderStyle = new Button();
            btnResize = new Button();
            btnOpacity = new Button();
            btnShow_nForm = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBorderStyle
            // 
            btnBorderStyle.Location = new Point(61, 31);
            btnBorderStyle.Name = "btnBorderStyle";
            btnBorderStyle.Size = new Size(97, 23);
            btnBorderStyle.TabIndex = 0;
            btnBorderStyle.Text = "Border Style";
            btnBorderStyle.UseVisualStyleBackColor = true;
            btnBorderStyle.Click += btnBorderStyle_Click;
            // 
            // btnResize
            // 
            btnResize.Location = new Point(200, 30);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(75, 23);
            btnResize.TabIndex = 1;
            btnResize.Text = "Resize";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnOpacity
            // 
            btnOpacity.Location = new Point(339, 31);
            btnOpacity.Name = "btnOpacity";
            btnOpacity.Size = new Size(75, 23);
            btnOpacity.TabIndex = 2;
            btnOpacity.Text = "Opacity";
            btnOpacity.UseVisualStyleBackColor = true;
            btnOpacity.Click += btnOpacity_Click;
            // 
            // btnShow_nForm
            // 
            btnShow_nForm.Location = new Point(497, 32);
            btnShow_nForm.Name = "btnShow_nForm";
            btnShow_nForm.Size = new Size(112, 23);
            btnShow_nForm.TabIndex = 3;
            btnShow_nForm.Text = "Show nForm";
            btnShow_nForm.UseVisualStyleBackColor = true;
            btnShow_nForm.Click += btnShow_nForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 108);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "******************";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnShow_nForm);
            Controls.Add(btnOpacity);
            Controls.Add(btnResize);
            Controls.Add(btnBorderStyle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Location = new Point(100, 200);
            Name = "Form1";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.Manual;
            Text = "Trey Research";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorderStyle;
        private Button btnResize;
        private Button btnOpacity;
        private Button btnShow_nForm;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
