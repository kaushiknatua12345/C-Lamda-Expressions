using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
             new Employee() {Id=1001,Name="Kaushik",Department="RDES"},
             new Employee() { Id = 1002, Name = "Arvind", Department = "Perceptive" },
            new Employee() { Id = 1004, Name = "Yana", Department = "Content Services" },
            new Employee() { Id = 1005, Name = "Joel", Department = "HxP ADF" }
            };

            //Find whether a record exists and if it exists display it
            Operations op=new Operations();
            Console.WriteLine("Enter Id to search: ");

            int searchId=Convert.ToInt32(Console.ReadLine());
            Employee searchedData = op.FindEmployee(employees,searchId);

            if (searchedData != null)
            {
                Console.WriteLine("\nId: " + searchedData.Id + "\nName: " + searchedData.Name +
                    "\nDepartment: " + searchedData.Department);
            }
            else
                Console.WriteLine("\nNo record found");

            Console.ReadLine();
        }
    }
}
