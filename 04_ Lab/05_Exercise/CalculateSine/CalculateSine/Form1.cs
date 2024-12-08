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

namespace CalculateSine
{
    public partial class Form1 : Form
    {
        public double minInterval; // начало интервала
        public double maxInterval; // конец интервала

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetInterval_Click(object sender, EventArgs e)
        {

            FormInterval formInterval = new FormInterval();
            formInterval.ShowDialog(this);  // Показать форму модально 
            //formInterval.Show(this);  // Показать форму не модально 

            lblIntervalSine.Text = "Левая граница: " + minInterval + ", правая граница: " + maxInterval;
            MethCalcSine();
        }

        private void MethCalcSine()
        {           
            double resSine;
            StringBuilder sb = new StringBuilder();

            for (double k = minInterval; k <= maxInterval; k+=0.1)
            {
                resSine = Math.Sin(k);
                sb.Append(k + " : " + resSine.ToString("N2") + "\n");               
            }
            rtbListSine.Text = sb.ToString();

        }       
    }
}
