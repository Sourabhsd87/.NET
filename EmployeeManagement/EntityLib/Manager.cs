using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLib
{
    [Serializable]
    public class Manager : Employee,Salary
    {
        private double Tallounce;
        private double healthInsuarance;
        //int id, string name, double baseSalary, DateTime joinDate, empType type
        public Manager(int id, string name, double basesalary, DateTime joindate, empType type, double tallounce, double healthInsu) : base(id, name, basesalary, joindate, type)
        {

            this.Tallounce = tallounce;
            this.healthInsuarance = healthInsu;
        }

        public double tallounce{
            get{ return this.Tallounce; }
            set { this.Tallounce = value; }
        }
        public double HealthInsuarance
        {
            get { return this.healthInsuarance; }
            set
            {
                this.healthInsuarance = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " | "+this.computesalary();
        }

        public double computesalary()
        {
            return base.computesalary()+Tallounce+healthInsuarance;
        }

    }
}
