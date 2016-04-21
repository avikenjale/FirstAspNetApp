using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace FirstAspNetApp.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController:Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{"Student 1","student 2"};
        }
        
        [HttpGet]
        public string Get(int id)
        {
            return "Student 1";
        }
    }
}