using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            //myPath.AddPolygon(new Point[] { new Point(0, 0), 
            //                                new Point(0, this.Height), 
            //                                new Point(this.Width, 0)}
            //);
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

            // Центрируем кнопку button1 относительно формы Form1
            SetButton1Center();

        }

        private void SetButton1Center()
        {
            // Сбрасываются анкерные стили и режимы докирования.
            button1.Anchor = AnchorStyles.None;
            button1.Dock = DockStyle.None;
            // Кнопка центрируется путем установки её левой и верхней позиций в середине формы.
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
        }
        // Не используется, т.к. форма не изменяет размер
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButton1Center();
        }
    }
}
