using BOL;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBManager
    {
        private static string connString = @"server=localhost;port=3306;user=root; password=root123;database=dotnetwebproject";



        public static List<Employee> getAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string query = "SELECT * FROM employees";
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string empname = reader["empname"].ToString();
                    string designation = reader["designation"].ToString();
                    Department department = Enum.Parse<Department>(reader["department"].ToString());
                    string city = reader["city"].ToString();
                    double salary = double.Parse(reader["salary"].ToString());
                    DateOnly joindate = DateOnly.Parse(reader["joindate"].ToString().Substring(0,10));
                    Employee newemployee = new Employee(id, empname, designation, department, city, salary,joindate);
                    employees.Add(newemployee);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }

            return employees;
        }//end of getallmethod
        public static void insertEmployee(Employee newemployee)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string query = "insert into employees values('" + newemployee.ID + "','" + newemployee.EMPNAME + "','" + newemployee.DESIGNATION + "','" + newemployee.DEPARTMENT + "','" + newemployee.CITY + "','" + newemployee.SALARY +"','"+newemployee.JOINDATE.ToString("yyyy-MM-dd") + "')";
                cmd.CommandText = query;
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " rows inserted.");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); }

        }

        public static void deleteEmployee(int id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                conn.Open();
                string query = "DELETE FROM employees WHERE id=" + id;
                command.CommandText = query;

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
        }
        public static Employee getById(int id)
        {
            Employee newemployee = new Employee();
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connString;
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                string query = "SELECT * FROM employees WHERE id=" + id;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int empid = int.Parse(reader["id"].ToString());
                    string empname = reader["empname"].ToString();
                    string designation = reader["designation"].ToString();
                    Department department = Enum.Parse<Department>(reader["department"].ToString());
                    string city = reader["city"].ToString();
                    double salary = double.Parse(reader["salary"].ToString());
                    DateOnly joindate = DateOnly.Parse(reader["joindate"].ToString());
                    newemployee = new Employee(empid, empname, designation, department, city, salary,joindate);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }

            return newemployee;
        }

        public static void UpdateEmp(Employee emp)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string query = "UPDATE employees SET empname='"+emp.EMPNAME+"',designation='"+emp.DESIGNATION+"',department='"+emp.DEPARTMENT+ "',city='"+emp.CITY+"',salary='"+emp.SALARY+"',joindate='"+emp.JOINDATE.ToString("yyyy-MM-dd") + "' WHERE id="+emp.ID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
//private int id;
//private string empname;
//private string designation;
//private Department department;
//private string city;
//private DateTime joiningdate;
