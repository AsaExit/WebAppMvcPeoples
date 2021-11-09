using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult People()// change to people from Index
        {
            return View();
        }
    }//End of Class name
}//End of namespace
