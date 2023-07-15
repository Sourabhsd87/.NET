using EntityLib;
using Accounts;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.AccessControl;

Console.WriteLine("-----Welcome to Transflower.Pvt.Ltd------");



Company company = new Company("transflower","12345");

bool exit = false;
Console.ReadLine();
while (!exit)
{
    Console.WriteLine("Press 1 : To add new employee | press 2 : To Check List of Employee. | press 3 : default Employee | " +
        "press 4 : show all managers info | press 5 : show all employees | press 6 : serialize | press 7 : deserialize");
    
    string choice = Console.ReadLine();

    Console.WriteLine(choice);

    switch (choice)
    {
        case "1":
            //int id ,string name,double baseSalary, DateTime joinDate,empType type
            Console.WriteLine("Enter Id | Name | BaseSalary | JoinDate | Employee Type");
            Employee newEmp = new Employee(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), DateTime.Parse(Console.ReadLine()), Enum.Parse<empType>(Console.ReadLine()));
            company.EmployeeList.Add(newEmp);
            break;
        case "2":
            Console.WriteLine("------Employees--------- ");
            List<Employee> empList = company.EmployeeList;
            foreach (var employee in empList)
            {
                Console.WriteLine(employee);
            }
            break;
        case "3":
            Employee newEmp3 = new Employee(12," malhar", 6999, new DateTime(2022,06,04), Enum.Parse<empType>("TEMPORARY"));
            Manager newMan1 = new Manager(23, " SOMESH", 60000, new DateTime(2018, 06, 04), Enum.Parse<empType>("PERMANENT"), 3000, 2000);
            Manager newMan2 = new Manager(24, " Sasdfgh", 40000, new DateTime(2015, 06, 04), Enum.Parse<empType>("TEMPORARY"), 7000, 7000);
            Employee newEmp1 = new Employee(13, " SOMESH", 60000, new DateTime(2021, 05, 04), Enum.Parse<empType>("PERMANENT"));
            Manager newMan3 = new Manager(26, " poiuyt", 30000, new DateTime(2017, 06, 04), Enum.Parse<empType>("TEMPORARY"), 3000, 2000);

            Employee newEmp2 = new Employee(15, " TUSHAR", 64000, new DateTime(2020, 03, 11), Enum.Parse<empType>("PERMANENT"));

            company.EmployeeList.Add(newEmp3);
            company.EmployeeList.Add(newEmp2 );
            company.EmployeeList.Add(newEmp1);
            company.EmployeeList.Add(newMan1);
            company.EmployeeList.Add(newMan2);
            company.EmployeeList.Add(newMan3);
            break;
        case "4":
            List<Employee> list = company.EmployeeList;

            foreach (var e in list)
            {
                if(e.GetType() == typeof(Manager))
                {
                    Console.WriteLine(e);
                }
            }
            break; 
        case "5":
            List<Employee> List= company.EmployeeList;
            foreach (var e in List)
            {
                if(e.GetType() == typeof(Employee))
                {
                    Console.WriteLine(e);
                }
            }
            break;
        case "6":
            List<Employee> li = company.EmployeeList;
            var option = new JsonSerializerOptions { IncludeFields = true };
            var empjson = JsonSerializer.Serialize<List<Employee>>(li, option);
            string filename = @"D:\dotNet\Day5_practice\employeeList.json";
            File.WriteAllText(filename, empjson);

            break;
        case "7":
            string filename1 = @"D:\dotNet\Day5_practice\employeeList.json";
            string desData = File.ReadAllText(filename1);
            List<Employee> emplist = JsonSerializer.Deserialize<List<Employee>>(desData);
            Console.WriteLine("----deserialized data----");
            foreach(Employee e in emplist)
            {
                Console.WriteLine($"{e.Id }:{ e.Name}:{ e.Type}");
            }

            break;
        default:
            exit = true;
            break;
            
    }
}



