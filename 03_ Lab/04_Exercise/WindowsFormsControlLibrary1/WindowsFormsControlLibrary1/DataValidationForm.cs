using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsControlLibrary1
{
    public partial class DataValidationForm : UserControl
    {
        public DataValidationForm()
        {
            InitializeComponent();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(tbName, "Must be letter");
                //MessageBox.Show("Поле Name не может содержать цифры");                
            }
            else { errorProvider1.Clear(); }
        }

        private void tbPIN_Validating(object sender, CancelEventArgs e)
        {
            if (tbPIN.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(tbPIN.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                    tbPIN.Text = "";
                }
            }
        }
    }
}
