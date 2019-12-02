using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            // using (var db = new CompanyContext())
            // {
            //     // Create                
            //     db.Department.Add(new Department { Name = "R&D2", Location = "2nd floor" });
            //     db.Department.Add(new Department { Name = "R&D1", Location = "4th floor" });
            //     db.Department.Add(new Department { Name = "R&D3", Location = "6th floor" });
            //     db.Department.Add(new Department { Name = "R&D4", Location = "8th floor" });
            //     var rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"{rowsAffected} row(s) inserted.");

            //     //Read
            //     Console.WriteLine("Querying for departments");
            //     var departments = from dep in db.Department
            //                       orderby dep.Id
            //                       select dep;
            //     var depart = departments.First();

            //     //Update
            //     Console.WriteLine("Updating Department");
            //     var department = db.Department.FirstOrDefault();
            //     department.Location = "14th Floor";
            //     rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"{rowsAffected} row(s) updated.");

            //     //Delete
            //     db.Department.Remove(department);
            //     rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"{rowsAffected} row(s) deleted.");
            // }

            // Employees
            using (var context = new CompanyContext())
            {
                //Create
                var departments = context.Department.Where(x => x.Name == "R&D1");                
                var department = departments?.First();

                var employee1 = new Employee 
                { 
                    Name = "ABC", 
                    Designation = "Manager", 
                    DOB = DateTime.Now,
                    Department = department
                };
                var employee2 = new Employee 
                { 
                    Name = "ABC ABC", 
                    Designation = "SE", 
                    DOB = DateTime.Parse("1990/12/12"),
                     Department = department
                };
                
                context.Employee.Add(employee1);
                context.Employee.Add(employee2);
                int rowsInserted = context.SaveChanges();
                Console.WriteLine($"{rowsInserted} rows inserted on Employee Table");

                //Fetching
                var departms = context.Department.Include(e => e.Employees).ToList();
                var thoraiData = context.Department.SkipWhile(x => x.Location == "KTM");
                
            }
        }
    }
}
