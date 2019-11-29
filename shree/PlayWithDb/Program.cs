using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace PlayWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var db = new CompanyContext())
            {
                /*db.Dispose()
                * it will dispose for cleanup garbase collection
                * for this we should use USING keyword instead of db.Dispose() */


           /*     db.DepartmentTable.Add(new Department { Id = 1, Name = "R & D 1", Location = "4Th Floor" });
                db.DepartmentTable.Add(new Department { Id = 2, Name = "R & D 1", Location = "4Th Floor" });
                db.DepartmentTable.Add(new Department { Id = 3, Name = "R & D 2", Location = "5Th Floor" });
                var rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} rows inserted");

               // inserting
                Console.WriteLine("Querying for departments");
                var departments = from dept in db.DepartmentTable
                                  orderby dept.Id
                                  select dept;
                var depFirst = departments.First();

                //updaing
                Console.WriteLine("Updating Department and adding employee");
                var department = db.DepartmentTable.Where(x => x.Id == 1).FirstOrDefault();
                department.Location = "1st Floor";
                department.Employees.Add(new Employee {Id=10, Name="Hari", Designation="Software Engineer", DepartmentId=10, Salary=10000.00D, Dob=DateTime.Now});
                var rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} rows updated");

                // delete
                db.DepartmentTable.Remove(department);
                rowsAffected = db.SaveChanges();
                Console.WriteLine($"{rowsAffected} row deleted");       */


            // create employee

            using (var context=new CompanyContext())
                {
                var departments = context.DepartmentTable.Where(x => x.Name == "R & D 1");      // where return collections not single item
                var department = departments?.First();

                // create
                var employee1 = new Employee
                {
                    Name = "Ram", 
                    Designation = "Manager", 
                    Dob = DateTime.Parse("1990/01/15"),
                    Department=department,
                    Salary = 50000.00
                };
                var employee2 = new Employee 
                { 
                    Name = "hari", 
                    Designation = "software engineer", 
                    Dob = DateTime.Parse("1990/01/15"),
                    Department=department,
                    Salary = 50000.00 
                };
                    

                    /*if (departments.Any())
                    {
                        var dept = departments.FirstOrDefault();
                    }  
                    var x = employee1 ?? new Employee();     
                    /*  ?? is Null Colease operator
                     * ?? chain can be multiple like var x=a ?? b ?? c?? d
                     * ?? is quite difference with NVL ( ) function 
                     * if x is non null, x= employee 1
                     * else x = new Employee()
                     */

                    //  var department = departments?.FirstOrDefault();     // ?. is  NULL PROPAGATION operator


                    //  bool isThereAnyDataWithNameR&D1 = context.DepartmentTable.Any(x => x.Name == "R & D 1");    -- to check any
                    //  bool isThereAnyDataWithNameR&D1 = context.DepartmentTable.All(x => x.Name == "R & D 1");    -- to check on all      */

                    
                    context.EmployeeTable.Add(employee1);
                    context.EmployeeTable.Add(employee2);
                    int rowsInserted = context.SaveChanges();
                    Console.WriteLine($"{rowsInserted} row inserted");

                // Fetching
                var deptms = context.DepartmentTable.Include(e => e.Employees).ToList();
                var lessData = context.DepartmentTable.Skip(40).Take(20);
                // this skip 40 rows and then take another 20 after it

                var lessData1 = context.DepartmentTable.SkipWhile(x => x.Location == "kathmandu");
              // this will skip rows while location = Kathmandu 
            }
            }

        }
    }
            
            
            