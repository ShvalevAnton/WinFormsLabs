using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateSine
{
    public partial class FormInterval : Form
    {
        public FormInterval()
        {
            InitializeComponent();
        }        

        private void btnSendData_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                double tmp1;
                double tmp2;
                bool isValid = Double.TryParse(tbMinInterval.Text, out tmp1) & Double.TryParse(tbMaxInterval.Text, out tmp2);
                if (isValid)
                {
                    frm1.minInterval = tmp1;
                    frm1.maxInterval = tmp2;
                }
                else
                {
                    MessageBox.Show("Ошибка! Введите число.");
                }
            }

            this.Close();
        }
    }
}
