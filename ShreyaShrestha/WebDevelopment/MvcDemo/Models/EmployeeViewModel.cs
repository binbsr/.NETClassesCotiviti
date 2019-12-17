using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcDemo.Models {
        public class EmployeeViewModel {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public DateTime Dob { get; set; }
                public int DepartmentId { get; set; }

                public string DepartmentName {get; set;}
                public SelectList DD_Departments { get; set; }

        }
}