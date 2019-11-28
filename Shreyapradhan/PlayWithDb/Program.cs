using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
           /* using (var db=new CompanyContext())
            {
                // insert into depatment ?? create
                db.Add(new Department{Name="R&D2",Location="2nd floor"});
                db.Add(new Department{Name="R&D1",Location="4th floor"});
                db.Add(new Department{Name="R&D3",Location="6th floor"});
                db.Add(new Department{Name="R&D4",Location="8th floor"});
                //db.Department.Add(new Department{Name="R&D2",Location="2nd floor"});
                var rowsAffected=db.SaveChanges();
                Console.WriteLine($" {rowsAffected} row(s) affected ");

                // Read
                Console.WriteLine("Reading Data from Department table");
                var departments= from dep in db.Department
                                orderby dep.Id
                                select dep;
               // var department=departments.First();
                // Updated
                Console.WriteLine("updating Department table and adding employee");
                var department=db.Department.Where(x=>x.Id==1).FirstOrDefault();
                department.Location="14th floor";
                //department.Employees.Add(new Employee{Name="Shreya Pradhan",Salary=234344.02D,DOB=DateTime.Now});
                //var emp1=new Employee{Name="Shreya Pradhan",Salary=234344.02D,DOB=DateTime.Now,Department=department};
                //db.Add(emp1);
                rowsAffected=db.SaveChanges();
                Console.WriteLine($" {rowsAffected} row(s) updated ");

                //Delete
                var depatment1=db.Department.Where(x=>x.Id==2).FirstOrDefault();
                db.Department.Remove(department);
                db.SaveChanges();
                Console.WriteLine($" {rowsAffected} row(s) deleted ");

                                
            }
            //Employees*/

            using(var context=new CompanyContext())
            {
                 var depts= context.Department.Where(x=>x.Name.Equals("R&D1"));

                // var x= emplpyee1?? new Employee() null coalseing operator
                var dept=depts?.First(); 
                // create 
                var employee1=new Employee{Name="ABC",Designation="Manager",DOB=DateTime.Now,Department=dept};
                var employee2=new Employee{Name="DEF",Designation="SE",DOB=DateTime.Parse("1990/12/12"),Department=dept};
               // propogation operator doesnot executee first if depts is nul and assigns null in dept
                context.Employee.Add(employee1);
                context.Employee.Add(employee2);
                int rowsInserted=context.SaveChanges();
                Console.WriteLine($" {rowsInserted} row(s) inserted in employee table ");


               
                var departments=context.Department.Include(e=>e.Employees).ToList();
                var lessData=context.Department.Skip(40).Take(20);
                var lessData1=context.Department.SkipWhile(x=>x.Location=="KTM");




            }

        }
    }
}
