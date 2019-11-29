using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlaywithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new CompanyContext())//if used in this way no need of db.dispose()
            {
              //Insert into department

              
            //   db.Add(new Department{name="R&D2",Location="2nd floor"});
            //   var rowsAffected=db.SaveChanges();
            //   Console.WriteLine($"{rowsAffected} row(s) inserted");

              //Read
            //   Console.WriteLine("Querying for Department");
            //   var departments=from dep in db.Department 
            //                  orderby dep.ID
            //                 select dep;
            //                 var depFirst=departments.First();
            //                 Console.WriteLine(depFirst);

            //Update
            //     Console.WriteLine("Updating Department and adding employee");
            //     var department = db.Department.Where(x => x.ID == 1).FirstOrDefault();
            //     department.Location = "4th floor";
            // var emp1=new Employee {name = "Kajol Shakya", salary = 123123.02, DOB = DateTime.Now,Department=department};
            // db.Add(emp1);
            //    var rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"{rowsAffected} rows(s) updated");

             //Delete
            //  db.Department.Remove(department);
            //  rowsAffected=db.SaveChanges();
            //  Console.WriteLine($"{rowsAffected} row(s) deleted.");

            }
           //Employees
           using(var context=new CompanyContext())
           {
               //Create
               
                var departments=context.Department.Where(x=> x.name=="R&D1");
               // bool isThereAnyDataWithNameR&D1=context.Department.All(x=> x.name=="R&D1");
              
                  var department=departments?.First();
                  var employee1=new Employee
               {name="ABC",Designation="Manager",DOB=DateTime.Now,Department=department};
                var employee2=new Employee{name="EFG",Designation="SE",DOB=DateTime.Parse("1990/12/12"),Department=department};
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
