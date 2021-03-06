﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpClass.Inheritance
{
    public abstract class BaseEmployee          // does not allow to create object of this class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string GetFullName() => $"{FirstName} {LastName}";
        public virtual double CalculateMonthlySalary()
        {
            return 0.0;
        }
        /*
         *Keyword virtual is use to override the method
         */

        public abstract double CalculateTax();
        /*
         * here keyword abstract is used
         * using keyword abstract, every child class of base class must implement abstract method
         * does not have body part of method just like INTERFACE
         */

}
    public sealed class FullTimeEmployee: BaseEmployee          // here SEALED keyword is used to stop class inheritance
    {
        public double MonthlySalary { get; set; }
        public string GetFullName() => $"{base.GetFullName()} - Full Time Employee";
        public override double CalculateMonthlySalary() => 1000;

        /* here GetFullName () - method hidding , 
         * derived class hides base class methods
         * here keyword BASE is use to call method GETFULLNAME ( ) from base class
         */

        public override double CalculateTax()
        {
            return 123.456;
        }

    }

    public class Contractor: BaseEmployee
    {
        public double HourlyWage { get; set; }
        public string GetFullName() => $"{base.FirstName} {base.LastName} - Contractor Employee";

        public override double CalculateMonthlySalary() => HourlyWage*160;
        public override double CalculateTax()
        {
            return 987.654;
        }
    }

    public class student
    {
        public int id;
        public string name;
        public string address;
        public string collegeName;

        public void GetStudentInformation(int id, string stdName, string stdAddress, string nameOfCollege)
        {
            this.id = id;
            name = stdName;
            address = stdAddress;
            collegeName = nameOfCollege;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine(id+name+address+collegeName);
        }
    }


    /*student s1 = new student();
    s1.GetStudentInformation(1,"ram","balaju","NCIT");
    s1.DsiplayStudentInfo();
    */

    public class NewStudentClass
    {        
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string CollegeName { get; set; }    
    }

}



