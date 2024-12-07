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

namespace TestStandartDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для сохранения содержимого элемента управления RichTextBox в
        // файл с использованием стандартного диалога сохранения файла (SaveFileDialog).
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Эта строка устанавливает фильтр для выбора файлов в диалоговом окне.
            // В данном случае фильтруются файлы с расширением .txt.
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            // Метод ShowDialog() отображает диалоговое окно сохранения файла.
            // Условие проверяет, выбрал ли пользователь файл и подтвердил сохранение
            // (результат равен System.Windows.Forms.DialogResult.OK), а также что имя файла не пустое.
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                // Содержимое richTextBox1 сохраняется в указанный пользователем файл в формате простого текста (PlainText).
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // Метод для изменения цвета фона элемента управления RichTextBox с использованием стандартного диалога выбора цвета (ColorDialog).
        private void tsmiColorBackground_Click(object sender, EventArgs e)
        {
            // Метод ShowDialog() отображает диалоговое окно выбора цвета.
            // Условие проверяет, выбрал ли пользователь цвет и подтвердил выбор (результат равен DialogResult.OK).
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        // Метод для открытия и загрузки файла в элемент управления RichTextBox с использованием стандартного диалога открытия файла (OpenFileDialog).
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();   //Создается новый экземпляр класса OpenFileDialog.
            openFileDialog1.InitialDirectory = @"c:\";  // Устанавливается начальная директория для поиска файлов (InitialDirectory)
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Устанавливается фильтры для выбора файлов (Filter) 
            openFileDialog1.FilterIndex = 2;    // Устанавливается индекс выбранного фильтра по умолчанию (FilterIndex).
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Внутри блока try-catch открывается поток для чтения файла с помощью метода OpenFile().
                // Если поток успешно открыт, содержимое файла загружается в richTextBox1 с использованием метода LoadFile().
                // В случае возникновения ошибки выводится сообщение с описанием исключения.
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName,
                            RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk: " + ex.Message);
                }
            }
        }
    }
}
