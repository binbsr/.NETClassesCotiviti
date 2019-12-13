

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Department
    {
    public int Id { get; set;}
    public string Name { get; set;}
    public string Location { get; set;}
    public List<Employee> Employees {get;set;}
    }
}