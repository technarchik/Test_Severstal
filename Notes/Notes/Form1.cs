using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Notes;

namespace Notes
{
    public partial class Form1 : Form
    {
        string fullpath;
        string folderName;
        List<FileInfo> NotesList = new List<FileInfo>();
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // создание директории
            string path = @"C:\First_Notes";
            string subpath = @"My_Notes";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Directory.CreateDirectory($"{path}/{subpath}");

            fullpath = path + "\\" + subpath;
            

            // создание первой заметки
            fullpath = path + "\\" + subpath;
            ClassNote firstNote = new ClassNote(fullpath);
            firstNote.WriteFirstNote(fullpath);

            nameOfNote.Text = "first_note";
            noteBody.Text = "It's your first note! Write smth here...";

            // обновление списка
            listOfNotes.Items.Clear();
            listOfNotes.Items.AddRange(Directory.GetFiles(fullpath).Select(x => Path.GetFileNameWithoutExtension(x)).ToArray());


            DirectoryInfo dinfo = new DirectoryInfo(@"C:\First_Notes\My_Notes");
            FileInfo[] Files = dinfo.GetFiles("*");
            folderName = dinfo.FullName; 
        }

        // сохранение заметки
        private void saveButton_Click(object sender, EventArgs e)
        {
            // хотелось установить путь сохранения и открытия по умолчанию, но не нашла, как это реализовать
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, noteBody.Text);
            }
        }

        // открытие заметки
        private void openButton_Click(object sender, EventArgs e)
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
        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(saveButton, "Сохранить");
        }

        // подсказки для кнопки открытия
        private void openButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(openButton, "Открыть");
        }

        // подсказка для кнопки доп. заметки
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(addButton, "Добавить дополнительную заметку");
        }

        // подсказка для кнопки удаления
        private void deleteButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(deleteButton, "Удалить выбранную заметку");
        }

        // реализация создания нескольких заметок
        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Activate();
            (new Form2()).Show();
        }

        // удаление заметки
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listOfNotes.SelectedIndex != -1)
            {
                string filepath = Path.Combine(folderName, listOfNotes.Items[listOfNotes.SelectedIndex].ToString());
                if (File.Exists(filepath))
                    File.Delete(filepath);
                listOfNotes.Items.RemoveAt(listOfNotes.SelectedIndex);
            }
        }

        // событие на обновление списка
        private void noteBody_MouseClick(object sender, MouseEventArgs e)
        {
            listOfNotes.Items.Clear();
            listOfNotes.Items.AddRange(Directory.GetFiles(fullpath).Select(x => Path.GetFileNameWithoutExtension(x)).ToArray());
        }

        // кривенькая реализация списка
        private void listOfNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            noteBody.Clear();
            string item = listOfNotes.SelectedItem.ToString();
            noteBody.Text = item;

            //пыталась сделать список, открывающий любой формат, но не получалось поймать путь и передать его, то есть не читался текст из файла
            // так как не получилось сделать открытие через список для любого формата файла, пришлось делать через try-catch
            try
            {
                noteBody.Text = File.ReadAllText(fullpath + "\\" + item);
                nameOfNote.Text = item;
            }
            catch
            {
                noteBody.Text = File.ReadAllText(fullpath + "\\" + item + ".txt");
                nameOfNote.Text = item;
            }


            //неудачные попытки создать список

            //if (listOfNotes.SelectedIndex != -1)
            //{
            //    string filepath = Path.Combine(folderName, listOfNotes.Items[listOfNotes.SelectedIndex].ToString());
            //    if (File.Exists(filepath))
            //        noteBody.Text = File.ReadAllText(filepath);
            //}


            //noteBody.Text = item;
            //string[] allfiles = Directory.GetFiles(fullpath, ".txt");

            //foreach (string filename in allfiles)
            //{
            //    listOfNotes0.Items.Add(allfiles);
            //}


            //StreamWriter newNote = new StreamWriter(path + name);
            //newNote.WriteLine(note);
            //newNote.Close();

            //foreach (string filename in allfiles)
            //{
            //noteBody.Text = allfiles[0];
            //notebody.text = filename;
            //}
        }

        //пыталась сделать список, открывающий любой формат, но не получалось поймать путь и передать его, то есть не читался текст из файла
        //вообще оптимальнее было бы сделать с помощью JS, но опыта в нем мало, только приступили к его иучению в вузе

        //ListBox lbx = new ListBox(); 

        //неудачные попытки сделать список //(было в Form1_Load)

        //NotesList = new DirectoryInfo(fullpath).GetFiles().ToList().FindAll((fi) => (fi.Extension.StartsWith(".txt", true, null))).ToList();
        //listOfNotes.Items.AddRange(NotesList.ConvertAll((fi) => Path.GetFileNameWithoutExtension(fi.Name)).ToArray());

        //var Files = Directory.GetFiles(fullpath, ".txt");
        //int numfiles = 10000;
        //lbx.Size = new System.Drawing.Size(100, 100); //Set to desired Size.
        //lbx.Location = new System.Drawing.Point(50, 50); //Set to desired Location.
        //this.Controls.Add(lbx); //Add to the window control list.
        //lbx.DoubleClick += OpenFileandBeginEditingDelegate;
        //lbx.BeginUpdate();
        //for (int i = 0; i < numfiles; i++)
        //    lbx.Items.Add(Files[i]);
        //lbx.EndUpdate();


        //private void OpenFileandBeginEditingDelegate(object sender, MouseEventArgs e)
        //{
        //    string file = listOfNotes.SelectedItem.ToString();
        //    FileStream fs = new FileStream(fullpath, FileMode.Open);

        //    //Now add this to the textbox 
        //    byte[] b = new byte[1024];
        //    UTF8Encoding temp = new UTF8Encoding(true);
        //    while (fs.Read(b, 0, b.Length) > 0)
        //    {
        //        noteBody.Text += temp.GetString(b);//tbx being the textbox you want to use as the editor.
        //    }
        //}


        //private void OpenFileandBeginEditingDelegate(object sender, EventArgs e)
        //{
        //    string file = lbx.SelectedItem.ToString();
        //    FileStream fs = new FileStream(fullpath, FileMode.Open);

        //    //Now add this to the textbox 
        //    byte[] b = new byte[1024];
        //    UTF8Encoding temp = new UTF8Encoding(true);
        //    while (fs.Read(b, 0, b.Length) > 0)
        //    {
        //        noteBody.Text += temp.GetString(b);//tbx being the textbox you want to use as the editor.
        //    }
        //}


        //неудачные попытки сделать список
        //private void listOfNotes_DropDown(object sender, EventArgs e)
        //{
        //    listOfNotes.Items.Clear();
        //    listOfNotes.Items.AddRange(Directory.GetFiles(fullpath).Select(x => Path.GetFileNameWithoutExtension(x)).ToArray());
        //}
    }
}
