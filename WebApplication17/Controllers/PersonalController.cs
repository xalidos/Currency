using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        [HttpGet("GetPersonal")]
        public List<Personal2> pers()
        {
            return PersonalList.pers;
        }
        [HttpGet("GetName")]
        public Personal2 personal2(string Name)
        {
            Personal2 personal = PersonalList.pers.Where(o => o.name == Name).SingleOrDefault();
            return personal;
        }


    }
}
