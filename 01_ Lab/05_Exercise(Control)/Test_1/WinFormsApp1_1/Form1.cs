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

            // ���������� ������ button1 ������������ ����� Form1
            SetButton1Center();

        }

        private void SetButton1Center()
        {
            // ������������ �������� ����� � ������ �����������.
            button1.Anchor = AnchorStyles.None;
            button1.Dock = DockStyle.None;
            // ������ ������������ ����� ��������� � ����� � ������� ������� � �������� �����.
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
        }
        // �� ������������, �.�. ����� �� �������� ������
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButton1Center();
        }
    }
}
