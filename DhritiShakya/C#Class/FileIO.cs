using System.IO;
namespace FileHandling
{
   public class FileIO
   {
     public DirectoryInfo CreateFolder(string path)
     {
       var result=Directory.CreateDirectory(path);
       return result;
     }

     public void CreateFile(string path,string content="Hello World")
     {
         File.WriteAllText(path,content);
     }
        internal void CreateFile(string path, string[] content) => File.WriteAllLines(path, content);
        internal string[] ReadFile(string path)
     {
         var filecontent=File.ReadAllText(path);
         var lines =filecontent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);
         return lines;
     }

     public void ReadBlackPeter(string path)
     {
         blackpetercontent=File.ReadAllText(path);
        
     }
     public int NumberOfCharacters()
     {
        return blackpetercontent.Length;
     }

     

       public int NumberOfLines(string )
     {
        var lineCount = File.ReadLines(@"C:\file.txt").Count();
     }

     internal void CreateFileUsingStreamWriter(string path,string filecontent)
     {
        StreamWriter sw=new StreamWriter(path);
        sw.WriteLine(filecontent);
        sw.Flush();
        sw.Close();
     }

     internal void AppendTextUsingStreamWriter(string path,string filecontent)
     {
        StreamWriter sw=new StreamWriter(path,true);
        sw.WriteLine(filecontent);
        sw.Flush();
        sw.Close();
     }
   }
}