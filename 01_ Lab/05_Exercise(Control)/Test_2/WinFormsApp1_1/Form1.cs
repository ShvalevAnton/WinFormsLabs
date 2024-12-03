using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Drawing2D;

namespace Test_2
{
    public partial class RombForm : Form
    {
        public RombForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();

            // Определяем размеры формы и координаты вершин ромба.
            myPath.AddPolygon( new Point[] {
                                             new Point(this.Width / 2, 0),
                                             new Point(this.Width, this.Height / 2),
                                             new Point(this.Width / 2, this.Height),
                                             new Point(0, this.Height / 2)
                                           }
            );
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
