using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.Services;

namespace WebAppMvcPeoples.Controllers
{
    public class AjaxPeopleController : Controller
    {
        private readonly IPeopleService _peopleService;
        //private readonly ICityService _cityService;
        //private readonly ICountryService _countryService;
        public AjaxPeopleController()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SpaPeopleList()
        {
            return PartialView("_SpaPeopleList", _peopleService.GetAll());
        }
        
        public IActionResult SpaPersonDetails(int id)
        {
            Person person = _peopleService.FindById(id);
            if (person == null)
            {
                return NotFound();
                //return PartialView("_SpaPersonDetails", person);

            }
            return PartialView("_SpaPersonDetails", person);
            //return NotFound();
        }
        public IActionResult SpaPeopleRow(int id)
        {
            Person person = _peopleService.FindById(id);

            if (person == null)
            {
                return NotFound();
            }

            return PartialView("_SpaPeopleRow", person);
        }
            public IActionResult SpaAjaxDelete(int id)
        {
            Person person = _peopleService.FindById(id);
            if (_peopleService.Remove(id))
            {
               return PartialView("_SpaPeopleList", _peopleService.GetAll());
            }

            return NotFound();
        }
    }
}
