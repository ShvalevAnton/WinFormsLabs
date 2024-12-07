using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer2
{
    public partial class UserControlTimer2 : Control
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    base.OnPaint(pe);
        //}
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // Создаём экземпляр класса "Поверхность для рисования" 
            Graphics g = pe.Graphics;

            // Закрашивание всей области элемента управления синим цветом.Метод FillRectangle заполняет прямоугольник указанным цветом.
            // В данном случае прямоугольник занимает всю область элемента управления(this.Width и this.Height).
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);

            // Вывод текущего времени в левом верхнем углу элемента управления. Метод DrawString используется для вывода текста на экран.
            // В качестве параметров передаются строка с текущим временем (DateTime.Now.ToLongTimeString()), шрифт (this.Font),
            // кисть для цвета текста (new SolidBrush(this.ForeColor)) и координаты начала вывода текста (в данном случае 0, 0).
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(), this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
