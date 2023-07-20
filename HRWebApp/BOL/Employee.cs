﻿using System.Transactions;

namespace BOL
{
    public enum Department { HR,SALES,FINANCE,MARKETING,ITSUPPORT}
    public class Employee
    {
        private int id;
        private string empname;
        private string designation;
        private Department department;
        private string city;
        private double salary;

        public Employee()
        {

        }

        public Employee(int id,string name,string designation, Department dept,string city,double salary)
        {
            this.id = id;
            this.empname = name;
            this.designation = designation;
            this.city = city;
            this.salary=salary; 
            this.department = dept;

        }
        public int ID { get { return id; } set { this.id = value; } }
        public string EMPNAME { get { return empname; } set { this.empname = value; } }
        public Department DEPARTMENT { get { return department; } set { this.department = value; } }
        public string CITY { get { return city; } set { this.city = value; } }
        public double SALARY { get {  return salary; } set {  this.salary = value; } }
        public string DESIGNATION { get { return designation; } set { this.designation = value; } }

        public override string ToString()
        {
            return this.id + " | " + this.empname + " | " + this.designation + " | " + this.department + " | " + this.city + " | " + this.salary;
        }

    }
}