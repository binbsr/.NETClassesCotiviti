using System.IO;
namespace Filehandling {
    public class FileIo {
        public DirectoryInfo CreateDFolder (string path) {
            var result = Directory.CreateDirectory (path);
            return result;
        }

        public void CreateFile (string path, string content = "Hello World") {
            File.WriteAllText (path, content); // creates file if not present and writes the content 
        }

        public void CreateFile (string path, string[] content) {
            File.WriteAllLines (path, content);
        }

        internal string[] ReadFile (string path) {
            var content = File.ReadAllText (path);
            var lines = content.Split (",", System.StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }

        //-------------------Nov 21 Class--------------------------------
        internal void CreateFileUsingStreamWriter (string path, string filecontent) {
            StreamWriter sw = new StreamWriter (path);
            sw.WriteLine (filecontent);
            sw.Flush (); //clear buffer
            sw.Close (); //destroy object from the memory
        }

        internal void AppendTextUsingStreamWriter (string path, string texttoppend) {
            StreamWriter sw = new StreamWriter (path, true);
            sw.WriteLine (texttoppend);
            sw.Flush (); //clear buffer
            sw.Close (); //destroy object from the memory
        }
    }
}