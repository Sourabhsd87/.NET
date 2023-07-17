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
            string fileName = @"D:\dotNet\Day7_practice\ABCD\employeeData.json";
            File.WriteAllText(fileName, empjson);
        }
    }
}
