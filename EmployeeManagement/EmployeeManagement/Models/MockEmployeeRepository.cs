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
               new Employee() {Id = 1, Name = "Rizwan", Email= "ri@gamil.com", Department = Dept.HR }, 
               new Employee() {Id = 2, Name = "Rumi", Email= "ru@gamil.com", Department = Dept.IT }, 
               new Employee() {Id = 3, Name = "Rahman", Email= "ra@gamil.com", Department = Dept.Payroll } 
            }; 
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(employee);

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
