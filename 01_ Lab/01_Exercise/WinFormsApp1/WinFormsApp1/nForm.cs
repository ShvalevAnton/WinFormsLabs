using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class nForm : Form
    {
        private bool nclose = false;

        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выбор режима закрытия второго окна. checkBoxClose.Checked = true  окно закрыто, = false окно работает в фоновом режиме
            //if (checkBoxClose.Checked) return;

            if (nclose) return;

            e.Cancel = true;
            Hide();
        }       
        
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }
    }
}
