Name: shree krishna gurung
dept: R&D1
Team: Team customization

Nov 4: Introduction to .Net and c#, .Net Framework, .Net infrastructure, IDE and GIT

Nov 5: Learned about Data types, console and console application

Nov 6: Learned about Iteration and array, namespace and Exercise 1

Nov 7: conditional (if else and ternary) and Exercise 2

Nov 8: Learned Nested For loop, methods with return type, optional argument and variable argument in methods, returning multiple values from methods

Nov 11: Learned Generic type, its implementation, arraylist, inbuilt list and dictionary and its implementation

Nov 12: Learned Constructor, class and Worked on Exercise 4

Nov 13: Learned class properties, getter and setter, discussed on  auto implemented properties,  Enum, constant and read only data type

Nov 14: Learned Static class data, methods, class and its implementation, private, public and static constructor

Nov 18: Learned Inheritance, multiple inheritance, interface

Nov 19: Discussed on virtual method, override method, abstract class and method

Nov 20: file and directory handling

Nov 22: Learned 

Nov 23:

Nov 24:

Nov 25:

Nov 26: Discussed on entity framework core

Nov 27: Discussed on CRUD operation on database / Datatable

Nov 29: Discussed on basics of HTML element


dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef --version 3.0.0
dotnet ef migrations add InitialDbCreate 
dotnet ef database update
dotnet ef migrations add SalaryColumnDataTypeToDouble
dotnet ef migrations add InitialCreate