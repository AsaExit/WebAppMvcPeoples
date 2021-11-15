using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
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
            return View(_peopleService.All());
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
                try
                {
                    _peopleService.Add(createPerson);
                }
                catch (ArgumentException exception)
                {
                    ModelState.AddModelError("Name,Phonenumber & City", exception.Message);
                    return View(createPerson);
                }
             
                return RedirectToAction(nameof(People));
            }
            return View(createPerson);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Person person = _peopleService.FindById(id);

            if (person == null)
            {
                return RedirectToAction(nameof(People));
                //return NotFound();//404
            }

            return View(person);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Person person = _peopleService.FindById(id);
            _peopleService.Remove(id);
            if (person == null)
            {
                return RedirectToAction(nameof(People));
                //return NotFound();//404
            }
            return RedirectToAction(nameof(People));
            //return View(); 
        }
    }//End of Class name
}//End of namespace
