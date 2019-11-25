using System;
using System.Collections.Generic;

public class Students
{
    public string fName { get; set; }
    public string lName { get; set; }
    public string address { get; set; }
    public string collegeName { get; set; }
    public DateTime dob { get; set; }

}
public class StudentCollection
{
    public static List<Students> FetchStudents()
    {
        List<Students> students = new List<Students>();
        students.Add(new Students {fName = "Bikram", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});
        students.Add(new Students{fName = "Kajol", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});
        students.Add(new Students{fName = "Sristi", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});            
        students.Add(new Students{fName = "Pawan", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});            
        students.Add(new Students{fName = "Dhriti", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});            
        students.Add(new Students{fName = "Pala", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});            
        students.Add(new Students{fName = "Shreya", lName = "KC", address = "Sukedhara", collegeName = "IOE Pulchowk", dob = DateTime.Parse("2041/05/10")});
        return students;
    }
}