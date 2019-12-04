Name       : Pala Kansakar
i-number   : i82200
Department : R&D1
TeamName   : Payment Customization


Monday,11th November: BAsic introduction to C# and dot net 
Wednesday,13th November: 
------------------------------------------------------------------
Thursday, 7th November 2019
1. Shift alt F-- code format
2. Learnt to use Method inside class and call from Main function.
3. Created Method using ifelse, learnt to use bolleen expression (&&, ||)
4. Difference between WriteLine,Write.
5. Learnt to use basic ternary. 
6. Learnt to convert string to int , string to char using Convert.tochar
------------------------------------------------------------------
Friday , 8th November 2019
1. Different approach to define methods
2. Declare Method Syntax : (accessmodifer,return type,Name[arguments..])
Learnt about: Return Argments, Passing Varable number of arguments,Passing optional Arguments,
3. Returning Multiple Values form Methods
4.Learnt String interpolation 
5.Learnt using tuple .
6.Learnt Named Argument while passing in arugemnt
------------------------------------------------------------------
Monday , 11th November 2019
Learned about Genric , Make List<string> , Dictonary 
Tuesday, 12th November 2019
Wednesday , 13th Novemver 2019

Thursday , 14th November,2019
1. Studied about Static class and memebers,
2. Static class declared only when all properties and method are static
3. Instance member accessed by instance
4. Static property accessed by class
5. only static value accessed in static method
6. static constructor called only once first time by object


Monday: 18th November , 2019
1. Studied about inheritance and Interface .
2. Class Object is assigend in Interface: Dependecy --loosly couple 
3. No body in interface
4. Inheritance
5. Base class- parnet class
6. Derived class - child class
7. Multiple Base class cannot be derived from derived class
8. Accessin Ability (Multiple method )is called Interface from classes, it has no body.
9. Calling object via interface interface c = new puppy() class puppy constructor first.

Tuesday: 19th November 2019
1. Learnt about keywords,
//sealed -- cannot be inherated in class //selaed class also called concrete base class
//abstrct similatr to interface using override
//instance can't be made and called  using abstract method
//virtual method similar to overriding but it is not compulsary
// Method hiding- (using keywordBase )base class method hide by derived class
//base implementation when using method of base class (using keyword base.method of baseclass)
//Key word new to hide method and properties

Wednesday : 20th November 2019
1. learnt about creting folder and file
2. Readline , alltext of a file
3. split the lines words, text, in a file 

Thursday : 21st November 2019
1. Started (LINQ) language intregated  Query
2. Create  new project LINQ using dotnet new console -n LINQ
3. using dotnet x=>x. using lamda(=>) expression where x. is list of item
3. two syntax to use lamda : 
   -- Method Syntax to use LINQ x=>x.StartWith("S")
   -- Query Expression syntax - using query while extracting the values using keys to access value (example list)

Friday: 22nd November ,2019
REvision of 21st November on LINQ , expressions
And also learned groupby Query as well

Monday: 25th November 2019
Today we learnt to use join using declarative query 

Tuesday: 26th November 2019
Entity Framework
install sqlite 
creating database table with classes
run follwing commands
dotnet add package Microsoft.EntityFrameworkCore --version 3.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.0.1
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 3.0.1
dotnet tool install --global dotnet-ef --version 3.0.0
dotnet ef migrations
dotnet ef migrations add InitialDbCreate (creation Migration folder)
dotnet build
dotnet ef database update



wednesday : 27th November 2019
Learnt to insert Rows in Table
Learnt to use migration command while chaging that the datatyoe of the table  (dotnet ef migrations add SalaryColumnDatatypeToDouble)
Learnt to use updatig the table.


thursday: 28th November 2019
learnt to use first select first data
Using foreign key in table by calling object 
//var employee1 = new Employee(){Name = "ABC",Designation ="Manager",DOB = DateTime.Now,Department = dept}
This command calls object of department to insert in employee table
//var departms = context.Department.Include(e=>e.Employees).ToList();
include used to take all data in employee table which are in department
//var x = employee1 ?? new Employee();//Null collesion - > if the value of employee is null then x=employee else x calls object and stores it 
//var thoraiData = context.Department.SkipWhile(x => x.Location == "KTM");
skipwhile ised to skipe the statement until it is true
//bool isthereAnyDataThere = ContextBoundObject.Department.where (x=>x.Name.all());
written the bool value and check if it has all data or not


Friday: 29th November 2019
Learnt to use css .. tags, css styling , inline and block line styling
Created Forms


Monday: 2nd December 2019
https://getbootstrap.com/docs/4.4/components/forms/#select-menu
Learnt to use bootstrap to edit css templates(coiler plate code)
Desinged forms using Bootstrap.css template
paddong is used in parent element
  chainging inside content 

Margin : related to whole body

