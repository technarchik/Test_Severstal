using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes;

namespace Notes
{
    public partial class Form2 : Form
    {
        string fullpath;
        public Form2()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void Form2_Load(object sender, EventArgs e)
        {
            string path = @"C:\First_Notes";
            string subpath = @"My_Notes";
            fullpath = path + "\\" + subpath;
        }

        // сохранение доп. заметки
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, noteBody.Text);
            }
        }

        // открытие доп. заметки
        private void openButton_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                nameOfNote.Text = Path.GetFileNameWithoutExtension(name);
                noteBody.Clear();
                noteBody.Text = File.ReadAllText(name);
            }
        }

        // подсказки для кнопки сохранения
        private void saveButton_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(saveButton, "Сохранить");
        }

        // подсказки для кнопки открытия
        private void openButton_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(openButton, "Открыть");
        }

    }
}
