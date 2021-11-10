using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.Services;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService _peopleService;
        public PeopleController()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }

        public IActionResult People()
        {
            return View(_peopleService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePersonViewModel());
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                _peopleService.Create(createPerson);
                return RedirectToAction(nameof(People));
            }
            return View(createPerson);
        }
    }//End of Class name
}//End of namespace
