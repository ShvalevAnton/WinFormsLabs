using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication_
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        // Когда пользователь нажимает на пункт меню ToggleMenuItem, состояние флажка меняется на противоположное.
        // Цвет текста в ChildTextBox изменяется в зависимости от текущего состояния флажка:
        // - Если флажок установлен, текст становится синим;
        // - Если флажок снят, текст становится черным.
        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {
            // Если флажок установлен, текст становится синим.
            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
