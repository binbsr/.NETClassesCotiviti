using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            // using keyword -- dispose the object 
           /* using (var db = new CompanyContext())
            {
                // insert into department

                // db.Add(new Department{DepartmentName = "R&D1", Location ="5th Floor"});
                db.Department.Add(new Department { DepartmentName = "R&D1", Location = "4th Floor" });
                db.Department.Add(new Department { DepartmentName = "R&D2", Location = "2th Floor" });
                db.Department.Add(new Department { DepartmentName = "OPs", Location = "3rd Floor" });
                db.Department.Add(new Department { DepartmentName = "HR", Location = "6th Floor" });

                var rowsAffected = db.SaveChanges();

                Console.WriteLine($"{rowsAffected} row(s) inserted !!!");

                // Read
                Console.WriteLine("querying for departments");
                //var deps = db.Department.ToList();
                var deps = db.Department.Select(x => x);
                var deparments = from dep in db.Department
                                 orderby dep.Id ascending
                                 select dep;

                var depFirst = deparments.First();

                foreach (var item in deparments)
                {
                    Console.WriteLine($"{item.Id} {item.DepartmentName} {item.Location}");

                }

                Console.WriteLine($"{depFirst.Id} {depFirst.DepartmentName} {depFirst.Location}");

                // update
                // Console.WriteLine("updating for departments and adding employee");

                var department = db.Department.Where(x => x.Id == 2).FirstOrDefault();
                department.Location = "4th Floor";

                var emp1 = new Employee { Name = "Nitin Malla", Designation = "Sr. Software Engineer", Salary = 123213.02, DOB = DateTime.Now, DepartmentId = 1 };
                db.Add(emp1);
                rowsAffected = db.SaveChanges();

                Console.WriteLine($"{rowsAffected} row(s) updated !!!");
                //
                Console.WriteLine("updating for departments ");

                var department = db.Department.Where(x => x.Id == 2).FirstOrDefault();
                department.Location = "fourth Floor";

                rowsAffected = db.SaveChanges();

                Console.WriteLine($"{rowsAffected} row(s) updated !!!");

                //Delete
                db.Department.Remove(department);
                rowsAffected = db.SaveChanges();

                  Console.WriteLine($"{rowsAffected} row(s) deleted !!!");
                           

            }
            */
            //Employees
            using (var context = new CompanyContext())
            {
                // create
                var departments = context.Department.Where (x=> x.DepartmentName == "R&D1");

                var department = departments?.First(); // null propagation operations

                var employee1 = new Employee
                {
                    Name="ABC",
                    Designation="Manager", 
                    DOB = DateTime.Now, 
                    Department = department
                };
                var employee2 = new Employee
                {
                    Name="ABC ABC",
                    Designation="Software Engineer",
                    DOB = DateTime.Parse("1990/12/12"), 
                    Department=department
                };

                
               // bool isTherAnyDataWithNameR&D1 = context.Department.Any (x=> x.DepartmentName == "R&D1");

               /* if (departments.Any())
                {
                    var department = departments.FirstOrDefault();

                }*/

                // var x = employee1 ?? new Employee(); // null collasing operations

                 
                 context.Employee.Add(employee1);
                 context.Employee.Add(employee2);

                 var rowsAffected = context.SaveChanges();

                  Console.WriteLine($"{rowsAffected} row(s) inseted on Employee Table !!!");
                
                // Fetching

                var departms = context.Department.Include ( e => e.Employee).ToList();
               // var thoraiData = context.Department.Skip(4).Take(2);
                //var littleData = context.Department.SkipWhile(x=> x.Location=="KTm");
                foreach (var item in departms)
                {
                    Console.WriteLine($"{item.Id} {item.DepartmentName} {item.Location}");
                    foreach (var item1 in item.Employee)
                    {
                        Console.WriteLine($"{item1.Id} {item1.Name} {item1.Designation} {item1.DOB} {item1.Salary}");
                    }
                }

            }

            //db.Dispose();
        }
    }
}
