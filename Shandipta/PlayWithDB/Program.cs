using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlayWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CompanyContext()){
              //  Insert into Department
            //     db.Add(new Department{Name="R&D1", Location="5th Floor"});
            //    var rowsAffected= db.SaveChanges(); //returns no. of affected rows
            //    Console.WriteLine($"No. of rows affected: {rowsAffected}");

                //Update
                Console.WriteLine("Updating Department and Adding Employee..");
                var getDepart = db.Department.Include(e=>e.Employee).ToList();

                var thoraiData = db.Department.Skip(1).Take(2); //helpful in server side pagination
                var thoraiData02 = db.Department.SkipWhile(x=>x.Location=="KTM");

                var getJoinTable = from dep in db.Department
                join emp in db.Employee 
                on dep.ID equals emp.DepartmentId
               select new {d=dep.Name, e=emp.Name};

                
                foreach(var v in getJoinTable){
                    Console.WriteLine($"{v.d} {v.e}");
                   
                }

                 
        
                // var department = db.Department.Where(x=>x.ID==3).FirstOrDefault();
                // department.Name="Operations";
                // department.Location="2nd Floor";
              //  db.Employee.Add(new Employee{Degisnation="ETL Developer", Name="Pawan KC", DepartmentId=2,Salary=60000,DOB=DateTime.Now});
              //  db.SaveChanges();
        //    var departments = db.Department.Where(x=>x.Name=="R&D1");
        //         var department = departments?.First();
        //         var emp1=new Employee
        //         {Degisnation="Software Engineer", 
        //         Name="Bhubhan Shrestha", 
        //         Department=department,
        //         Salary=600000,
        //         DOB=DateTime.Now};
                // var emp2=new Employee
                // {Degisnation="Software Developer", 
                // Name="EM THapa", 
                // DepartmentId=2
                // Salary=200000,
                // // DOB=DateTime.Now};
                // db.Employee.Add(emp1);
                // // db.Employee.Add(emp2);
                //  db.SaveChanges();
              // db.Add(new Employee{Degisnation="Software Developer", Name="Shandita Rai", Salary=200000, DOB=""});
            //if the table have zero records it will return null FirstOrDefault() 
            //whereas First() return error if no records
            //    Read
                // var dept = from dep in db.Department
                // orderby dep.ID descending
                // select dep;
                // var firstDepartment =dept.Last();
                // Console.WriteLine(firstDepartment.Name);
                // foreach(var d in dept){
                //     Console.WriteLine($"Id->{d.ID}, Name->{d.Name}, ->{d.Location}");

                // }
            }
            
            //dotnet CLR helps to clean up disposable objects with the help fo garbage collections 
            //db.Dispose();
            
        }
    }
}
