namespace EditPerson
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
            this.personsListView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btnlookList = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSurname,
            this.colAge});
            this.personsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsListView.HideSelection = false;
            this.personsListView.Location = new System.Drawing.Point(0, 0);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(434, 219);
            this.personsListView.TabIndex = 0;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            this.personsListView.VirtualMode = true;
            this.personsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView_RetrieveVirtualItem);
            // 
            // colName
            // 
            this.colName.Text = "Имя";
            this.colName.Width = 150;
            // 
            // colSurname
            // 
            this.colSurname.Text = "Фамилия";
            this.colSurname.Width = 150;
            // 
            // colAge
            // 
            this.colAge.Text = "Возраст";
            this.colAge.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(292, 233);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 30);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btnlookList
            // 
            this.btnlookList.Location = new System.Drawing.Point(51, 282);
            this.btnlookList.Name = "btnlookList";
            this.btnlookList.Size = new System.Drawing.Size(341, 30);
            this.btnlookList.TabIndex = 3;
            this.btnlookList.Text = "Просмотреть список";
            this.btnlookList.UseVisualStyleBackColor = true;
            this.btnlookList.Click += new System.EventHandler(this.btnlookList_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 193);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 518);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnlookList);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.personsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSurname;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btnlookList;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

