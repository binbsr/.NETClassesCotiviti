using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace PlayWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CompanyContext())
            {
                //Create

                db.Add(new Department {Name = "R&D1", Location = "5th floor"});
                var rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} rows(s) inserted");

                //Read

                Console.WriteLine("Querying for departments");
                var departments = from dep in db.Department
                                    orderby dep.Id
                                    select dep;
                var depFirst = departments.First();
                Console.WriteLine($"{depFirst}");


                //Update

                Console.WriteLine("Updating Department and adding employee");
                var department = db.Department.Where(x => x.Id == 1).FirstOrDefault();
                department.Location = "4th floor";
                var empl = new Employee {Name = "Kajol Shakya", Salary = 123123.02, DOB = DateTime.Now, Department = department};
                db.Add(empl);
                rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} rows(s) updated");

                //Delete
            //  db.Department.Remove(department);
            //  rowsAffected=db.SaveChanges();
            //  Console.WriteLine($"{rowsAffected} row(s) deleted.");
 
            }
           //Employees
           using(var context=new CompanyContext())
           {
               //Create
               
                var departments=context.Department.Where(x=> x.Name=="R&D1");
               // bool isThereAnyDataWithNameR&D1=context.Department.All(x=> x.name=="R&D1");
              
                  var department=departments?.First();
                  var employee1=new Employee
               {Name="ABC",Designation="Manager",DOB=DateTime.Now,Department=department};
                var employee2=new Employee{Name="EFG",Designation="SE",DOB=DateTime.Parse("1990/12/12"),Department=department};
                  context.Employee.Add(employee1);
                  context.Employee.Add(employee2);
                  int rowsInserted=context.SaveChanges();
                  Console.WriteLine($"{rowsInserted} rows inserted on employee table");
                
                //Fetching
                var departm= context.Department.Include(e=>e.Employees).ToList();
                var thoraiData=context.Department.Skip(40).Take(20);
               // var thoraiData=context.Department.SkipWhile(x=>x.Location=="KTM");
           }
            

        }
    }
}
