/* IndexController */
using PreSchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PreSchoolAPI.Controllers
{
    public class IndexController : ApiController
    {
        [HttpPost]
        [Route("AddEmployeeDetails")]
        public string AddEmployeeDetails([FromBody] EmployeeModel employeeModel)
        {
            return employeeModel.AddEmployeeDetails();
        }

        [HttpPost]
        [Route("GetEmployeeList")]
        public List<EmployeeModel> GetEmployeeList([FromBody] EmployeeModel employeeModel)
        {
            return employeeModel.GetEmployeeList();
        }

        [HttpPost]
        [Route("GetEmployeeDetails")]
        public EmployeeModel GetEmployeeDetails([FromBody] EmployeeModel employeeModel)
        {
            return employeeModel.GetEmployeeDetails();
        }

        [HttpPost]
        [Route("DeleteEmployee")]
        public string DeleteEmployee([FromBody] EmployeeModel employeeModel)
        {
            return employeeModel.DeleteEmployee();
        }

        [HttpPost]
        [Route("EditEmployeeDetails")]
        public string EditEmployeeDetails([FromBody] EmployeeModel employeeModel)
        {
            return employeeModel.EditEmployeeDetails();
        }

        [HttpPost]
        [Route("GetDesignation")]
        public List<EmployeeModel> GetDesignation()
        {
            EmployeeModel EmployeeModel = new EmployeeModel();
            return EmployeeModel.GetDesignation();
        }
    }
}











