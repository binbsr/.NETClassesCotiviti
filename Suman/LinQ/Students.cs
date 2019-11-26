using System;
using System.Collections.Generic;

class Students
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string CollegeName { get; set; }
    public DateTime DOB {get; set;}
}

class StudentCollection
{
    public static List<Students> FetchData()
    {
        List<Students> students = new List<Students>();
        students.Add( new Students{ID=1, Name = "Ram", CollegeName="KMC", DOB= DateTime.Parse("1992/06/02")});
        students.Add( new Students{ID=2, Name = "Shyam", CollegeName="TJHSS", DOB= DateTime.Parse("1995/07/25")});
        students.Add( new Students{ID=3, Name = "Hari", CollegeName="BHSS", DOB= DateTime.Parse("1993/06/03")});
        students.Add( new Students{ID=4, Name = "Gita", CollegeName="BHSS", DOB= DateTime.Parse("1992/06/12")});
        students.Add( new Students{ID=5, Name = "Sita", CollegeName="KU", DOB= DateTime.Parse("1991/12/21")});
        students.Add( new Students{ID=6, Name = "Rita", CollegeName="SWSS", DOB= DateTime.Parse("1993/01/22")});
        students.Add( new Students{ID=7, Name = "Nita", CollegeName="BHSS", DOB= DateTime.Parse("1994/04/02")});
        return students;
    }
}