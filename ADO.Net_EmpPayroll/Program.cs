using System;

namespace ADO.Net_EmpPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO.net Employee payroll system");
            //Read Operation

            CrudOperations crud = new CrudOperations();
            //crud.ReadEmployeeData();
            crud.CreateEmployeeData();

        }
    }
}

