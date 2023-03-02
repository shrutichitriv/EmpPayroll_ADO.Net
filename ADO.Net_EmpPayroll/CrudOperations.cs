using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//namespace ADO.Net_EmpPayroll
//{
//    public class CrudOperations
//    {
//        //crud operations
//        string connectionString = @"Data Source-(localdb)\MSSQLLocalDB;Initial Catalog-payroll_service;Integrated Security-True;";
//        public CrudOperations()
//        {
//            //connectionString = @"Data Source-(localdb)\MSSQLLocalDB;Initial Catalog-Employee;Integrated Security-True;";
//        }
//        public void ReadEmployeeData()
//        {
//            SqlConnection connection = new SqlConnection(connectionString);
//            string query = "SELECT ID, Name, Address, Salary, MobileNo FROM employee_payroll";
//            using (connection)
//            {
//                SqlCommand command = new SqlCommand(query, connection);
//                connection.Open();
//                command.CommandType = System.Data.CommandType.Text;
//                SqlDataReader dataReader = command.ExecuteReader();
//                while (dataReader.Read())
//                {
//                    Employee employee = new Employee();
//                    employee.Id = dataReader.GetInt32(0);
//                    employee.Name = dataReader.GetString(1);
//                    employee.Address = dataReader.GetString(2);
//                    employee.Salary = dataReader.GetInt64(3);
//                    employee.MobileNo = dataReader.GetString(4);

//                    Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Address}, {employee.Salary}, {employee.MobileNo}");
//                }
//                connection.Close();
//                Console.ReadKey();
//            }
//        }

      
//    }
//}
