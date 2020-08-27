using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EksiCodeBackend.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            List<string> testVerileri=new List<string>();
            testVerileri.Add("Navisio 1");
            return Ok(testVerileri);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> testVerileri = new List<string>();
            testVerileri.Add("Navisio 1");
            testVerileri.Add("Navisio 2");
            testVerileri.Add("Navisio 3");
            testVerileri.Add("Navisio 4");
            return Ok(new { success=true, users = testVerileri });
        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok("Veri Eklendi");
        }

        [HttpPatch]
        public IActionResult Update()
        {
            return Ok("Veri Guncellendi");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Veri Silindi");
        }
    }
}
