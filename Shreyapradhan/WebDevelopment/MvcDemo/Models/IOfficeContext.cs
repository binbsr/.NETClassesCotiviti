using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;
public interface IOfficeContext 
{

    DbSet<Department> Departments {get;set;}

    int SaveChanges();

}