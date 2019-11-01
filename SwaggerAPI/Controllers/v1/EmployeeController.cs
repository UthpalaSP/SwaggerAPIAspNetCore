using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Model;

namespace SwaggerAPI.Controllers.v1
{
    [Route("api/v1/[controller]")] //API version separation
    [ApiController]
    public class EmployeeController : Controller
    {
        // GET: api/v1/Employee  
        [HttpGet]
        public List<Employee> EmployeesDetails()
        {
            List<Employee> employees = new List<Employee>
            {
               new Employee
               {
                   Name = "Rajeesh",
                   Department = "Development",
                   Adress = "Menoth Parambil"
               },

               new Employee
               {
                   Name = "Arokia",
                   Department = "R/D",
                   Adress = "Trichy Central"
               },

               new Employee
               {
                   Name = "Vijay",
                   Department = "Cloud",
                   Adress = "MP Gowliyar"
               },

            };

            return employees;
        }

        // GET: api/v1/Employee/5  
        [HttpGet("{id}", Name = "Get")]
        public Employee EmployeeDetailsInformation(int id)
        {
            List<Employee> employees = new List<Employee>
            {
               new Employee
               {
                   id = 1,
                   Name = "Rajeesh",
                   Department = "Development",
                   Adress = "Menoth Parambil"
               },

               new Employee
               {
                   id = 2,
                   Name = "Arokia",
                   Department = "R/D",
                   Adress = "Trichy Central"
               },

               new Employee
               {
                   id = 3,
                   Name = "Vijay",
                   Department = "Cloud",
                   Adress = "MP Gowliyar"
               },

            };

            return employees.Find(x => x.id == id);
        }

        // POST: api/v1/Employee  
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v1")] //Declare group name locally
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/v1/Employee/5  
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/v1/ApiWithActions/5  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}