using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MyClass;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        List<Item> its = new List<Item>();  // список для хранения единиц хранения библиотеки
        public string Author // автор
        {
            get { return tbAutor.Text; }
            set { tbAutor.Text = value; }
        }
        public string Title // Название
        {
            get { return tbTitle.Text; }
            set { tbTitle.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return tbPub.Text; }
            set { tbPub.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)nudPages.Value; }
            set { nudPages.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)nudYear.Value; }
            set { nudYear.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)nudInvNum.Value; }
            set { nudInvNum.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return cbExistence.Checked; }
            set { cbExistence.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return cbSortInvNumber.Checked; }
            set { cbSortInvNumber.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return cbReturnTime.Checked; }
            set { cbReturnTime.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)nudPeriodUse.Value; }
            set { nudPeriodUse.Value = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            // Возвращена ли книга в срок?
            if (ReturnTime)
                b.ReturnSrok();
            // Расчет стоимости с учетом пользования книгой
            b.PriceBook(PeriodUse);
            // Добавить книгу в список its
            its.Add(b);
            // Очистить поля для следующей книги
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            // Проверка состояния флажка сортировки, если флаг установлен отсортировать список
            if (SortInvNumber)
                its.Sort();

            // Добавим список книг в StringBuilder для вывода на экран 
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            // Вывод списка книг на экран
            rtbEnterBooks.Text = sb.ToString();
        }
    }
}
