
namespace LinQ
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public abstract class Athelete
    {
        public int Id {get; set;}
        public string Name {get; set;}

        public string Sex {get; set;}

        public string Age {get; set;}

        public string Height {get; set;}

        public string Weight{get; set;}

    }

    public interface ITeam{
        public string Team {get;set;}
        public string NOC {get;set;}
    }

    public interface IOlympic{
        public string Games {get; set;}
        public string Year {get;set;}
        public string Season {get;set;}
        public string City {get; set;}
    }

    public interface IEvent{
        public string Sport {get; set;}
        public string Event{get;set;}
    }

    public class OlympicsAtheletesEvent :Athelete, ITeam, IOlympic, IEvent
    {
        public string Team { get ; set ; }
        public string NOC { get ; set ; }
        public string Games { get ; set ; }
        public string Year { get; set; }
        public string Season { get ; set; }
        public string City { get ; set; }
        public string Sport { get; set; }
        public string Event { get ; set ; }
        public string Medal {get;set;}
    }
    public class EventLists
    {
        public static List<OlympicsAtheletesEvent> OlympicsAtheletesEvent()
        {
            List<OlympicsAtheletesEvent> OlympicsAtheletesEvents = new List<OlympicsAtheletesEvent>();
           /* OlympicsAtheletesEvents.Add(new OlympicsAtheletesEvent { Id=1,Name="Nitin",Sex='M',Age=30,Height="123",Weight="70",Team="Nepal",NOC="NEP",Games ="1992 Summer",Year =1992,
            Season="Summer",City="Barcelona",Sport="Basketball",Event="Basketball Men's Basketball",Medal="NA"});
           */ 
            string folderPath = @"D:\dotnet_classes\files";
           
            FileIO fileIO = new FileIO();
            
            string filePath = Path.Combine(folderPath, "Olympics_Athelete_Events.txt");
            

            var results = fileIO.ReadFile(filePath);
          
            for (int i = 1; i < results.Length; i++)
            {
               // Console.WriteLine($"{i + 1} -> {results[i]}"); 
                 var str = results[i].Split(",",System.StringSplitOptions.RemoveEmptyEntries);
                OlympicsAtheletesEvents.Add(new OlympicsAtheletesEvent { Id=int.Parse(str[0]),Name=str[1],Sex=str[2],Age=str[3],Height=str[4],Weight=str[5],Team=str[6],NOC=str[7],Games =str[8],Year =str[9],
                    Season=str[10],City=str[11],Sport=str[12],Event=str[13],Medal=str[14]});
               
            }
            return OlympicsAtheletesEvents; 

        }
    }

    public class OutFile
    {
        int ID{get;set;}
        string name {get;set;}
    }
    public class FileIO
    {
        internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);

            return lines;
        }  
        public void CreateFile (string path, string[] content)
        {
            File.WriteAllLines (path, content);
           // File.WriteAllText (path, content);
        }      
    }
}