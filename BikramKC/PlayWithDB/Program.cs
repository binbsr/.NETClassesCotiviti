using System;
using System.Linq;

namespace PlayWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // using (var db = new CompanyContext())
            // {
            //     //insert into department
            //     db.Add(new Department { Name = "R&D2", Location = "2nd Floor" });
            //     var rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"Rows affected : {rowsAffected}");
            //     Console.WriteLine("lets read the table");
            //     var dep = from b in db.Department
            //               orderby b.Location
            //               select b;
            //     foreach (var item in dep)
            //     {
            //         Console.WriteLine($"Name : {item.Name}, Location : {item.Location}");
            //     }
            //     // update 
            //     var depRnD = db.Department.Where(x => x.Location == "2nd Floor").FirstOrDefault();
            //     Console.WriteLine("updating department");
            //     depRnD.Location = "Updated";
            //     db.Employee.Add(new Employee { DepartmentId = 2, Name = "Bikram KC", Salary = 23435.888, Designation = "Principal Engineer" });
            //     var rowsUpdated = db.SaveChanges();

            //     // Delete
            //     db.Department.Remove(depRnD);
            //     var rowsDel = db.SaveChanges();
            //     Console.WriteLine($"Rows Deleted :  {rowsDel}");

            // }
            // using (var context = new CompanyContext())
            // {
            //     var emp1 = new Employee { Name = "Shandipta", Designation = "Head of Department", DOB = DateTime.Parse("1990/12/12") };
            //     var emp2 = new Employee { Name = "Bikram", Designation = "Trainee", DOB = DateTime.Parse("2001/12/12") };
            //     var departments = context.Department.Where(x => x.Name == "R&D2");
            //     var department = departments.FirstOrDefault();

            //     // coalesce
            //     // var x = department ?? new Department();
            //     // Null propogate
            //     // var y = departments?.First();

            //     // emp1.DepartmentId = department.Id;
            //     // emp2.DepartmentId = department.Id;
            //     emp1.Department = department;
            //     emp2.Department = department;
            //     context.Employee.Add(emp1);
            //     context.Employee.Add(emp2);
            //     var count = context.SaveChanges();
            //     Console.WriteLine($"Employee added: {count}");            


            // }
            using (var fetchContext = new CompanyContext())
            {

                var emp = fetchContext.Employee.Where(x=> x.Name == "Bikram");
                foreach (var item in emp)
                {
                    var x = item.Department;
                    Console.WriteLine($"Name : {item.Name}, Department: {x.Name}");
                }


            }
        }
    }
}
