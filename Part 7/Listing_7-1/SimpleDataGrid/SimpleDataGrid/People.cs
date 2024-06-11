using SimpleDataGrid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataGrid
{
    public class People : ObservableCollection<Person>
    {
        public void AddPerson(int departmentNumber, 
            int employeeNumber, 
            string deskLocation,
            string firstName, 
            string lastName)
        {
            this.Add(new Person { DepartmentNumber = departmentNumber, 
                EmployeeNumber = employeeNumber,
                DeskLocation = deskLocation,
                FirstName = firstName, 
                LastName = lastName });
        }

        public People()
        {
            AddPerson(10, 1001, "R1F3R5T7", "John", "Plantagenet");
            AddPerson(10, 1002, "R1F1R2T3", "Richard", "Plantagenet");
            AddPerson(15, 1011, "R3F2R10T1", "Henry", "Tudor");
            AddPerson(20, 1021, "R7F4R10T7", "Elizabeth", "Tudor");
        }
    }
}
