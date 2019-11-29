using System;
//Entity Framework--windows based, not open source
//Entity Framework Core--cross platform, open source
//Can use any data provider
//It caches the fetched data for reducing the round trip of data and improves performace
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDB {
    class Program {
        static void Main (string[] args) {
            // var db=new CompanyContext();
            // //dispose object
            // db.Dispose();

            using (var db = new CompanyContext ()) //adding using automatically disposes the object
            {
                // //insert into department
                // // db.Add(new Department{Name="R&D1", Location="Fifth floor"});
                // // db.Add(new Department{Name="R&D2", Location="Forth floor"});
                // // db.Add(new Department{Name="R&D3", Location="third floor"});//here department table is implicitly referred
                // db.Department.Add (new Department { Name = "R&D4", Location = "sixth floor" }); //here department table is explicitly referred
                // db.Department.Add (new Department { Name = "R&D5", Location = "Ground floor" });
                // var rowsAffected = db.SaveChanges (); //returns the number of rows affected
                // //SaveChanges is transactional i.e. it takes all the above additions as a single transaction,
                // //if one of the addition fails, everything fails and SaveChanges does not save anything
                // Console.WriteLine ($"{rowsAffected} row(s) inserted in the Deparment table");

                // //Read all departments order by ID
                // Console.WriteLine ("Query to extract departments");
                // //deps and departments below store same result
                // var deps = db.Department.ToList ().Select (x => x);
                // var departments = from dep in db.Department orderby dep.ID select dep;
                // var depFirst = departments.First ();
                // var depI = deps.First ();
                // Console.WriteLine ($"{depFirst.ID} - {depFirst.Name}");
                // Console.WriteLine ($"{depI.ID} - {depI.Name}");

                // //Update
                // Console.WriteLine ("Updating department and adding employee in it");
                // var dept1 = db.Department.Where (x => x.ID == 22).FirstOrDefault (); //if no data then default value is taken
                // dept1.Location = "1st Floor";
                // var emp1 = new Employee { Name = "Sristi M", Designation = "Principal Engineer", Salary = 100000.0, DOB = DateTime.Now, Department = dept1 };
                // db.Add (emp1);
                // rowsAffected = db.SaveChanges ();
                // Console.WriteLine ($"{rowsAffected} row(s) inserted in the Deparment table");

                // //Delete
                // db.Department.Remove (dept1);
                // rowsAffected = db.SaveChanges ();
                // Console.WriteLine ($"{rowsAffected} row(s) deleted");

                //Employee
                using (var context = new CompanyContext ()) {

                    var departs = context.Department.Where (x => x.Name == "R&D4");
                    var department = departs?.First ();
                    var employee1 = new Employee { Name = "ABC", Designation = "Manager", DOB = DateTime.Now, Department = department };
                    var employee2 = new Employee { Name = "xyz", Designation = "SE", DOB = DateTime.Now, Department = department };
                    //bool isThereAnyDataWithR&D1=context.Department.Any(x=>x.Name=="R&D4");

                    // if(departs.Any())
                    // {
                    //     var department=departs.FirstOrDefault();
                    // }

                    //var x=employee1??new Employee();//??Null Collescing operation, if employee1 is null then returns new Employee
                    //?Null propagation operation,if departs is null then doex not execute further i.e. First

                    context.Employee.Add (employee1);
                    context.Employee.Add (employee2);
                    int rowsInserted = context.SaveChanges ();
                    Console.WriteLine ($"{rowsInserted} rows inserted on Employee table");

                    //Fetching
                    var departments=context.Department.Include(e=>e.Employees).ToList();
                    var filterData=context.Department.Skip(40).Take(20);
                    var skpWhile=context.Department.SkipWhile(x=>x.Location=="KTM");

                }

            }
        }
    }
}