using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository() 
        {
            _employeeList = new List<Employee>() 
            { 
               new Employee() {Id = 1, Name = "Rizwan", Email= "ri@gamil.com", Department = "Accounts" }, 
               new Employee() {Id = 2, Name = "Rumi", Email= "ru@gamil.com", Department = "Software" }, 
               new Employee() {Id = 3, Name = "Rahman", Email= "ra@gamil.com", Department = "Media" } 
            }; 
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
