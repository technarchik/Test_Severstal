using System.IO;

namespace Notes
{
    class ClassNote
    {
        private string name;

        public string Name // наименование заметки
        {
            get { return name; }
            set { name = value; }
        }

        public ClassNote() { }
        public ClassNote(string name)
        {
            this.name = name;
        }
        
        public void WriteFirstNote(string path) // создание первой заметки
        {
            string name = "\\first_note.txt";
            string note = "It's your first note! Write smth here...";
            StreamWriter newNote = new StreamWriter(path + name);
            newNote.WriteLine(note);
            newNote.Close();

        }
    }
}
