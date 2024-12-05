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
        public string Title { get; set; }   // Название
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
        public int Year { get; set; }   // Год издания

        public int InvNumber { get; set; }// Инвентарный номер

        public bool Existence { get; set; } // Наличие

        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return cbSortInvNumber.Checked; }
            set { cbSortInvNumber.Checked = value; }
        }
        public bool ReturnTime { get; set; }// Возвращение в срок

        public int PeriodUse // Инвентарный номер
        {
            get { return (int)nudPeriodUse.Value; }
            set { nudPeriodUse.Value = value; }
        }

        public string Volume // Том
        {
            get => tbVolume.Text;
            set => tbVolume.Text = value;
        }
        public int Number // Том
        {
            get => (int)nudNum.Value;
            set => nudNum.Value = value;
        }
        public bool Subscription
        {
            get => cbSub.Checked;
            set => cbSub.Checked = value;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TabControl0.SelectedTab == tabPage1)
            {
                //MessageBox.Show("Фокус покинул вкладку 'tabPage1'");
                // Выполняем какие-то действия для первой вкладки

                Title = tbTitle.Text;   // Название книги
                Year = (int)nudYear.Value;  // Год выпуска книги
                InvNumber = (int)nudInvNum.Value;  // Инвентарный номер книги
                Existence = cbExistence.Checked;    // Наличие книги
                ReturnTime= cbReturnTime.Checked;   // Вернули книгу в срок
            }

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

        private void btnAddM_Click(object sender, EventArgs e)
        {
            if (TabControl0.SelectedTab == tabPage2)
            {
                Title = tbTitleM.Text;    // Название журнала
                Year = (int)nudYearM.Value; // Дата выпуска журнала
                InvNumber = (int)nudInvNumM.Value;  // Инвентарный номер журнала
                Existence = cbExistenceM.Checked;   // Наличие журнала
                ReturnTime = cbSub.Checked;   // Вернули журнал в срок
            }
            Magazine b = new Magazine(Volume, Number, Title, Year, InvNumber, Existence);
            
            // Возвращен ли журнал в срок?
            //if (ReturnTime)
            //    b.Return();
            
            // Оформлена подписка на журнал?
            if(cbSub.Checked)
                b.Subs();
            // Добавить книгу в список its
            its.Add(b);
            // Очистить поля для следующей книги
            Volume = Title = "";            
            Number = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }        
    }
}
