using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Example3
{
    internal class Operations
    {
        public Employee FindEmployee(List<Employee> employees,int id)
        {
            return employees.Where(x=>x.Id == id).FirstOrDefault();
        }
    }
}
