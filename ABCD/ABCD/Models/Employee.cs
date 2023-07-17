using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contactNo { get; set; }

        public Employee() { }

        public Employee(string firstName, string lastName, string email, string password, string contactNo)
        {
            FirstName = firstName;
            LastName = lastName;
            this.email = email;
            this.password = password;
            this.contactNo = contactNo;
        }

        public override string ToString()
        {
            return "FirstName Name="+this.FirstName+",Last Name="+this.LastName+",Email="+this.email+",Contact No="+this.contactNo;
        }
    }
}
