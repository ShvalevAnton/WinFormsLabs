using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // если требуется очистить компонент перед загрузкой, то вызовите метод Clear:
            //peopleList.Items.Clear();

            // Cоздайте объект класса FileStream, представляющий содержимое xml-файла:
            FileStream fStream = new FileStream("C:\\MyGit\\WinFormsLabs\\02_ Lab\\02_Exercise\\TestList\\XMLData.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            // создайте объект класса XmlDocument и заполните его данными
            XmlDocument xmlDoc = new XmlDocument(); 
            xmlDoc.Load(fStream);

            // С помощью цикла for заполните компонент значениями внутреннего текста xml - документа:
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }

            //закройте файловый поток:
            fStream.Close();
        }
    }
}
