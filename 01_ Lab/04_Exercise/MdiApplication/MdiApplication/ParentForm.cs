namespace MdiApplication_
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Метод выполняет каскадное расположение всех открытых дочерних окон
        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        // Метод выполняет плиточное расположение всех открытых дочерних окон
        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            // Создаём новое дочернее окно
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " " + ++openDocuments;
            // Указываем текущую родительскую форму MDI дочерней форме
            newChild.MdiParent = this;
            //Метода Show() показывает дочернюю форму на экране
            newChild.Show();
        }
    }
}
