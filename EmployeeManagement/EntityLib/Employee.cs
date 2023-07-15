using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLib
{
    public enum empType { PERMANENT, TEMPORARY }

    [Serializable]
    public class Employee : Salary
    {
        private int id;
        private string name;
        private double baseSalary;
        private DateTime joinDate;
        private empType type;

        public empType Type { get { return type; } set { type = value; } }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double BaseSalary { get { return baseSalary; } set { baseSalary = value; } }
        public DateTime JoinDate { get { return joinDate; } set { joinDate = value; } }

        //public Employee() /*: this(1, "abc", 1000, new DateTime(2001,01,01), TEMPORARY)*/ { }

        public Employee(int id, string name, double baseSalary, DateTime joinDate, empType type)
        {
            this.id = id;
            this.name = name;
            this.baseSalary = baseSalary;
            this.joinDate = joinDate;
            this.type = type;
        }

        public override string ToString()
        {
            return this.id + " | " + this.name + " | " + this.baseSalary + " | " + this.joinDate + " | " + this.type;
        }

        public double computesalary()
        {
            return this.baseSalary + 2000;
        }
    }
}
