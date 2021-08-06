using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenBasedAuthentication.DAO;

namespace TokenBasedAuthentication.Service
{
    public class EmployeesService
    {
        private EmployeesDao employeesDao;
        public IEnumerable<Employee> getAllEmployees()
        {
            employeesDao = new EmployeesDao();
            return employeesDao.getAllEmployees();
        }
    }
}