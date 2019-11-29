using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithdb
{
    class Program
    {
        static void Main(string[] args)
        {/*
            using (var db = new CompanyContext())
            {
                
                //insert into department
                db.Department.Add(new Department { Name = "R&D2", Location = "2th floor" });
                db.Department.Add(new Department { Name = "R&D2", Location = "4th floor" });
                db.Department.Add(new Department { Name = "R&D2", Location = "6th floor" });
                db.Department.Add(new Department { Name = "R&D2", Location = "8th floor" });
            
                var rowsAffected = db.SaveChanges();
                //Console.WriteLine($"{rowsAffected} row(s) effected");

                //Read
                Console.WriteLine("Quering for Department");
                //var deps = db.Department.Select(x=>x);
                var departments = from dep in db.Department
                                  orderby dep.Id
                                  select dep;
                var depart = departments.First();

                //update
                Console.WriteLine("Updating department and adding employee");
                var department = db.Department.Where(x => x.Id == 1).FirstOrDefault();
                department.Location = "4th Floor";
                //department.Employees.Add(new Employee { Name = "Pawan", Salary = 2344232.02D, DOB = DateTime.Now });
                //var empl = new Employee { Name = "Pawan", Salary = 2344232.02D, DOB = DateTime.Now , Department = department};
                //db.Add(empl);
                rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} row(s) updated");

                //delete
                db.Department.Remove(department);
                db.SaveChanges();
                Console.WriteLine($"{rowsAffected} row(s) deleted");
            }*/
                
                //Employes
                using (var context = new CompanyContext())
                {

                    var departments=context.Department.Where(x=>x.Name.Equals("R&D1"));
                    var dept=departments?.First();
                    var employee1 = new Employee(){Name = "ABC",Designation ="Manager",DOB = DateTime.Now,Department = dept};
                    var employee2 = new Employee(){Name = "ABC",Designation ="Manager",DOB = DateTime.Parse("1990/10/10"),Department=dept};
                    var depts = context.Department.Where(x=>x.Name.Equals("R$D1"));
                    //bool isthereAnyDataThere = ContextBoundObject.Department.where (x=>x.Name.all());
                  //var x = employee1 ?? new Employee();//Null collesion
                  context.Employee.Add(employee1);
                  context.Employee.Add(employee2);
                  int rowsInserted = context.SaveChanges();
                  Console.WriteLine($"{rowsInserted} rows inserted on Employee Table ");

                  //Fetching
                  var departms = context.Department.Include(e=>e.Employees).ToList();
                  var thoraiData = context.Department.SkipWhile(x => x.Location == "KTM");

                }
                //Create employee



            

        }
    }
}
