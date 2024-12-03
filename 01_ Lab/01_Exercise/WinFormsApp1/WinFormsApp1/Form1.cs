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

        // ������� ��� ������ �� ������ btnBorderStyle
        private void btnBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        // ������� ��� ������ �� ������ btnResize
        private void btnResize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        // ������� ��� ������ �� ������ btnOpacity
        private void btnOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnShow_nForm_Click(object sender, EventArgs e)
        {
            //nForm myF2 = new nForm();
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            // ���� ��������� ���������� ObjectDisposedException, �� ���������� �������� ��������� ����,
            // � ����������� ������ catch ��������� ����� ����
            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new nForm();
                myF2.Text = "��������� �������� �����";
                myF2.Show();
                myF2.Activate();
            }
        }

        //����� ��� �������� ��������� ������� ����
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // �������� IsDisposed ���������� true, ���� ����� ���� ���������� (�������), � false � ��������� ������.
            label1.Text = "��������: " + (myF2.IsDisposed ? "���� \"myF2\" �������" : "���� \"myF2\" ��������");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }       
    }
}
