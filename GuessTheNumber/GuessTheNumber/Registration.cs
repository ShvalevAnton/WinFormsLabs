using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuessTheNumber
{
    public partial class regForm : Form
    {
        private Player plr;
        private List<Player> plrs;
        public regForm()
        {
            InitializeComponent();           
        }
        public regForm(Player plr, List<Player> plrs)
        {
            InitializeComponent();
            this.plr = plr;
            this.plrs = plrs;
        }
        public string _name
        {
            get { return tbName.Text; }
        }
        public string _pass1
        {
            get { return tbPass1.Text; }
        }
        public string _pass2
        {
            get { return tbPass2.Text; }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            // Был ли такой игрок с таким именем
            if (plrs.Any(p => p.Name.Equals(_name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Player with this name already exists. Please choose another name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            plr.Name = this._name;
            // Проверка правильности ввода пароля
            if (_pass1 == "" || _pass1 != _pass2)
            {   
                MessageBox.Show("Incorrect password entered. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            plr.Password = _pass1;
            MessageBox.Show($"Сreated profile: {plr.Name}, Password {plr.Password}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            plrs.Add(plr);
            this.Close();                    
        }
    }
}
