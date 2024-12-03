namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        nForm myF2;
        public Form1()
        {
            InitializeComponent();
            myF2 = new nForm();
        }

        // событие при нажати на кнопку btnBorderStyle
        private void btnBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        // событие при нажати на кнопку btnResize
        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        // событие при нажати на кнопку btnOpacity
        private void btnOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnShow_nForm_Click(object sender, EventArgs e)
        {
            //nForm myF2 = new nForm();
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            // Если возникает исключение ObjectDisposedException, но необходимо повторно запустить окно,
            // в обработчике ошибок catch создается новое окно
            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new nForm();
                myF2.Text = "Повторное создание формы";
                myF2.Show();
                myF2.Activate();
            }
        }

        //Метод для проверки состояния второго окна
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // свойство IsDisposed возвращает true, если форма была уничтожена (закрыта), и false в противном случае.
            label1.Text = "Проверка: " + (myF2.IsDisposed ? "Окно \"myF2\" закрыто" : "Окно \"myF2\" работает");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }       
    }
}
