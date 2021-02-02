using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandinAzureSql.AzureSQLDB;

namespace UnderstandinAzureSql
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(NayakEntities dbContext = new NayakEntities())
                {
                    List<Employee> employeeList = new List<Employee>()
                    {
                        new Employee(){ Name = "Mukesh", Age = 22 },
                        new Employee(){ Name = "Manan", Age = 27 },
                        new Employee(){ Name = "Juli", Age = 23}
                    };
                    

                    dbContext.Employees.AddRange(employeeList);
                    dbContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
