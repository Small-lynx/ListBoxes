using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int listIndex;

        /// <summary>
        /// Действия при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            var massLeft = new string[] { "Monday", "Tuesday", "Webnesday" };
            var massRight = new string[] { "Thurday", "Friday", "Saturday", "Sunday" };
            listLeft.Items.AddRange(massLeft);
            listRight.Items.AddRange(massRight);
        }

        /// <summary>
        /// Перенос строки из левого листа в правый
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            listRight.Items.Add(listLeft.Items[listLeft.SelectedIndex]);
            listLeft.Items.RemoveAt(listLeft.SelectedIndex);
            buttonRight.Enabled = false;
        }

        /// <summary>
        /// Перенос всех строк из левого листа в правый
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllRight_Click(object sender, EventArgs e)
        {
            listRight.Items.AddRange(listLeft.Items);
            listLeft.Items.Clear();
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
        }

        /// <summary>
        /// Перенос строки из правого листа в левый
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllLeft_Click(object sender, EventArgs e)
        {
            listLeft.Items.AddRange(listRight.Items);
            listRight.Items.Clear();
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
        }

        /// <summary>
        /// Перенос всех строк из правого листа в левый
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            listLeft.Items.Add(listRight.Items[listRight.SelectedIndex]);
            listRight.Items.RemoveAt(listRight.SelectedIndex);
            buttonLeft.Enabled = false;
        }

        /// <summary>
        /// Нажатие кнопки мыши у левого листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listLeft_MouseDown(object sender, MouseEventArgs e)
        {
            listIndex = 1;
            if (listLeft.SelectedItem != null)
            {
                listLeft.DoDragDrop(listLeft.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            if (listLeft.SelectedIndex == -1)
            {
                buttonRight.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
            }
        }

        /// <summary>
        /// Нажатие кнопки мыши у правого листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listRight_MouseDown(object sender, MouseEventArgs e)
        {
            listIndex = 2;
            if (listRight.SelectedItem != null)
            {
                listLeft.DoDragDrop(listRight.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            if (listRight.SelectedIndex == -1)
            {
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonLeft.Enabled = true;
            }
        }

        /// <summary>
        /// Эффекты при перетаскивании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void list_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Завершение перетаскивания в правый лист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listRight_DragDrop(object sender, DragEventArgs e)
        {
            if (listIndex == 1)
            {
                listRight.Items.Add(e.Data.GetData(DataFormats.Text));
                listLeft.Items.Remove(e.Data.GetData(DataFormats.Text));
                listIndex = 0;
            }
        }

        /// <summary>
        /// Завершение перетаскивания в девый лист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (listIndex == 2)
            {
                listLeft.Items.Add(e.Data.GetData(DataFormats.Text));
                listRight.Items.Remove(e.Data.GetData(DataFormats.Text));
                listIndex = 0;
            }
        }
    }
}
