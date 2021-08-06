using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DSOFile;
using TokenBasedAuthentication.Service;
using System.Data;
using System.Data.SqlClient;

namespace TokenBasedAuthentication.Controllers
{
    //[Authorize]
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        private EmployeesService employeesService;
        

        [HttpGet]
        [Route("getAllEmployees")]
        public IEnumerable<Employee> AllEmployees()

        {
            employeesService = new EmployeesService();
            return employeesService.getAllEmployees();
        }

        [HttpPost]
        [Route("saveJson")]
        public void saveAsJson()

        {
           
        }

    }
}
