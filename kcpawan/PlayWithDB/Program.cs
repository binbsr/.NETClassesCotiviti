using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            using(var db = new CompanyContext())
            {
                // CREATE
               
               /* db.Departments.Add(new Department{Name = "R&D1",Location = "5th Floor"});
                var rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} row(s) inserted");*/

                //READ

                Console.WriteLine("Reading data from Department table");
                //var deps = db.Departments.ToList();
               // var deps = db.Departments.Select(x=>x);
                var departments = from dep in db.Departments
                                    orderby dep.ID
                                    select dep;
                var depart = departments.First();

                
                //UPDATE
                /*
                Console.WriteLine("Updating Department");
                //var department = db.Departments.Where(x => x.ID == 2).FirstOrDefault();
                var department = db.Departments.FirstOrDefault();
                department.Location = "4th Floor";
                
              

                rowsAffected = db.SaveChanges();
                Console.WriteLine("Data Saved");*/


                //DELETE
               /* Console.WriteLine("Deleting item from Department");
                db.Departments.Remove(department);
                rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} row(S) deleted");*/


            }

            using (var context = new CompanyContext())
            {
                //Create
               
               /*
               var departments = context.Departments.Where(x=>x.Name == "R&D1");
                var department = departments?.FirstOrDefault();

                var employee1 = new Employee{Name = "Pawan", Designation = "Principal Engineer", DOB = DateTime.Now, Department = department};
                var employee2 = new Employee{Name = "Bikram", Designation = "Principal Engineer", DOB = DateTime.Now, Department = department};
              
                 
                    
                context.Employees.Add(employee1);
                context.Employees.Add(employee2);

                int rowsInserted = context.SaveChanges();
                Console.WriteLine($"{rowsInserted} row(S) inserted in Employees Table.");
                */


                //Fetching
                var departms = context.Departments.Include(e => e.Employees).ToList(); 
                var thoraiData = context.Departments.Skip(40).Take(20);
                var thoraiData1 = context.Departments.SkipWhile(x=>x.Location=="KTM");







               

            }

        }
    }
}
