using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InteractionWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            // #region 27th Nov Interaction with db
            // using (var db = new CompanyContext())
            // {
            //     //insert into department //Create
            //     //implicit way
            //     db.Add(new Department { Name = "R&D2", Location = "2nd Floor" });

            //     //explicit way
            //     db.Departments.Add(new Department { Name = "R&D1", Location = "4th Floor" });
            //     db.Departments.Add(new Department { Name = "R&D3", Location = "3rd Floor" });
            //     db.Departments.Add(new Department { Name = "R&D4", Location = "5th Floor" });
            //     db.Departments.Add(new Department { Name = "R&D5", Location = "6th Floor" });

            //     var rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"Number of row(s) affected is {rowsAffected}");

            //     //Read
            //     Console.WriteLine("Reading data from Departments tabble");
            //     var deps = db.Departments.ToList();
            //     var deps1 = db.Departments.Select(x => x).OrderBy(x => x.Id);
            //     var departmentOrderById = from dep in db.Departments
            //                               orderby dep.Id
            //                               select dep;
            //     //var department = departmentOrderById.First(); 

            //     //Update
            //     Console.WriteLine("Updating Department");
            //     //department.Location = "4th Floor";
            //     var department = db.Departments.Where(x => x.Id == 1).FirstOrDefault();
            //     department.Location = "14th Floor";
            //     rowsAffected = db.SaveChanges();
            //     Console.WriteLine($"{rowsAffected}");

            //     //Add
            //     // var emp1 = new Employee {Name = "Bishnu Rawal", Designation = "Principal Engineer", Salary = 100000D, Dob = DateTime.Now, Department = department };
            //     // db.Add(emp1);
            //     #endregion

            #region 28th Nov 2019
            // //Delete
            // db.Departments.Remove(department);
            // rowsAffected = db.SaveChanges();
            // Console.WriteLine($"{rowsAffected} row(s) deleted.");

            //Employees
            using (var context = new CompanyContext())
            {
                //Create employee
                var departments = context.Departments.Where(x => x.Name == "R&D1");
                var dpt = departments?.First(); //null propagation operator ?.

                var employee1 = new Employee { Name = "Bishnu Rawal", Designation = "Principal Engineer", Dob = DateTime.Now, Department = dpt };
                var employee2 = new Employee { Name = "Shandipta", Designation = "Software Engineer", Dob = DateTime.Parse("1990/10/13"), Department = dpt };

                //bool isThereAnyDataWithNameR&Dl = context.Departments.Any(x => x.Name == "R&D1");
                //bool isThereAnyDataWithNameR&Dl = context.Departments.All(x => x.Name == "R&D1");
                // if (departments.Any())
                // {
                //     var dpt = departments?.FirstOrDefault();
                // }
                var x = employee1 ?? new Employee(); // if employee1 is not null then x takes value of employee otherwise new Employee() null collease operator

                // var dpt = departments ?.First() = if departments is null then null is assgined in dpt only if departments is not null then first is assgined, no exception is thrown.

                context.Employees.Add(employee1);
                context.Employees.Add(employee2);
                int rowsInserted = context.SaveChanges();
                Console.WriteLine($"Rows inserted on employee is {rowsInserted}");


                //Fetching
                var department1 = context.Departments.Include(e => e.Employees).ToList();
                var chunk = context.Departments.Skip(40).Take(20);
                var a = context.Departments.SkipWhile(x=>x.Location == "KTM"); //Condition dina
                #endregion

            }

        }

    }
}

