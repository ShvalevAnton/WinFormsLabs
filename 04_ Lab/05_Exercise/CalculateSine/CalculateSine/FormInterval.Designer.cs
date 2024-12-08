namespace CalculateSine
{
    partial class FormInterval
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMinInterval = new System.Windows.Forms.TextBox();
            this.tbMaxInterval = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnCancelSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Границы интервала:";
            // 
            // tbMinInterval
            // 
            this.tbMinInterval.Location = new System.Drawing.Point(54, 72);
            this.tbMinInterval.Name = "tbMinInterval";
            this.tbMinInterval.Size = new System.Drawing.Size(115, 20);
            this.tbMinInterval.TabIndex = 1;
            // 
            // tbMaxInterval
            // 
            this.tbMaxInterval.Location = new System.Drawing.Point(216, 72);
            this.tbMaxInterval.Name = "tbMaxInterval";
            this.tbMaxInterval.Size = new System.Drawing.Size(115, 20);
            this.tbMaxInterval.TabIndex = 2;
            // 
            // btnSendData
            // 
            this.btnSendData.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendData.Location = new System.Drawing.Point(54, 111);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(115, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Передать данные";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnCancelSend
            // 
            this.btnCancelSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSend.Location = new System.Drawing.Point(216, 111);
            this.btnCancelSend.Name = "btnCancelSend";
            this.btnCancelSend.Size = new System.Drawing.Size(115, 23);
            this.btnCancelSend.TabIndex = 4;
            this.btnCancelSend.Text = "Отменить передачу";
            this.btnCancelSend.UseVisualStyleBackColor = true;
            // 
            // FormInterval
            // 
            this.AcceptButton = this.btnSendData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSend;
            this.ClientSize = new System.Drawing.Size(398, 170);
            this.Controls.Add(this.btnCancelSend);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.tbMaxInterval);
            this.Controls.Add(this.tbMinInterval);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInterval";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInterval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinInterval;
        private System.Windows.Forms.TextBox tbMaxInterval;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnCancelSend;
    }
}