using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    public partial class Form2 : Form
    {
        RombForm fRomb_1;
        public Form2()
        {
            InitializeComponent();
            fRomb_1 = new RombForm();
        }            

        private void button1_Click(object sender, EventArgs e)
        {
            //fRomb_1.StartPosition = FormStartPosition.Manual;
            //fRomb_1.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
            try
            {
                fRomb_1.Show();
                fRomb_1.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                fRomb_1 = new RombForm();
                //fRomb_1.Location = new Point(this.Location.X + this.Width / 2, this.Location.Y + this.Height / 2);
                fRomb_1.Show();
                fRomb_1.Activate();
            }
        }
    }
}
