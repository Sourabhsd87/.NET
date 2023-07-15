using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLib
{
    public class Company
    {
        private string companyName;
        private string licenceNo;
        private List<Employee> employeeList;

        public string CompanyName { get {  return companyName; } set {  companyName = value; } }

        public string LicenceNo { get { return licenceNo; } set { licenceNo = value; } }

        public List<Employee> EmployeeList { get {  return employeeList; } set {  employeeList = value; } }

        public Company() { }

        public Company(string companyName, string licenceNo)
        {
            CompanyName = companyName;
            LicenceNo = licenceNo;
            EmployeeList = new List<Employee>();
        }

        public override string ToString()
        {
            return this.CompanyName+" | "+this.LicenceNo;
        }
    }
}
