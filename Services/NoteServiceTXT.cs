using at.Models;

namespace at.Services
{
    public class NoteServiceTXT
    {
        private readonly string path = "wwwroot/files";

        public List<string> LoadNotes()
        {
            var notes = new List<string>();

            if (!System.IO.File.Exists(path))
                System.IO.Directory.CreateDirectory(path);

            foreach (var file in System.IO.Directory.GetFiles(path, "*.txt"))
            {
                notes.Add(System.IO.Path.GetFileNameWithoutExtension(file));
            }

            return notes;
        }

        public void SaveNote(string fileName, string content)
        {
            string filePath = path + "/" + fileName + ".txt";

            if (!System.IO.File.Exists(filePath))
                System.IO.File.Create(filePath).Close();

            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(content);
            sw.Close();
        }

        public string ReadNote(string fileName)
        {
            string filePath = path + "/" + fileName + ".txt";

            if (!System.IO.File.Exists(filePath))
                return null;

            string content = "";
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();

            while (line != null)
            {
                content += line + "\n";
                line = sr.ReadLine();
            }

            sr.Close();
            return content;
        }
    }
}
