using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace EmployeeManagementSystem.Presistant
{
    public class Serializing
    {
        public static void serialize(List<Employee> employees)
        {
            var option = new JsonSerializerOptions { IncludeFields = true };
            var empjson = JsonSerializer.Serialize<List<Employee>>(employees, option);
            string fileName = @"D:\dotNet\Day7_practice\New folder\.NET\ABCD\employeeData.json";
            Console.WriteLine(fileName);
            File.WriteAllText(fileName, empjson);
        }
        public static List<Employee> deserialize(string fileName)
        {
            string data = File.ReadAllText(fileName);
            List<Employee> result = JsonSerializer.Deserialize<List<Employee>>(data);
            return result;
        }
    }
}
