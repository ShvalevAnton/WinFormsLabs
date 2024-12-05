using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                this.but.Text = "First";
            else if (radioButton2.Checked == true)
                this.but.Text = "Second";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Разрывает потоковое расположение элементов. Следующий элемент (button7) начнёт располагаться с новой строки.
            flowLayoutPanel1.SetFlowBreak(button6, true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Создание новой кнопки
            Button aButton = new Button();
            // Добавить в панель TableLayoutPanel в ячейку с индексами (1, 1).
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);
        }

        // Таким образом, данный код переключает режим фиксирования между двумя панелями SplitContainer:
        // либо ни одна из них не зафиксирована, либо зафиксирована первая панель
        private void button10_Click(object sender, EventArgs e)
        {
            // Проверка текущего состояния фиксированной панели
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)                
                splitContainer1.FixedPanel = FixedPanel.None;   // Изменение фиксированной панели на отсутствие фиксации
            else
                splitContainer1.FixedPanel = FixedPanel.Panel1; // Иначе изменение фиксированной панели на Panel1
        }

        // Таким образом, эта строчка кода просто переключает состояние свойства IsSplitterFixed на противоположное.
        // Если до выполнения этой команды разделитель был заблокирован, он разблокируется, и наоборот.
        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
        }
        // Таким образом, эта строчка кода просто переключает состояние первой панели: если она была развернута, то сворачивается, и наоборот.
        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
        }
    }
}
