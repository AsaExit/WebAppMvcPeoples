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
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
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
       
        public IActionResult Delete(int id)
        {
            Person person = _peopleService.FindById(id);
            //_peopleService.Remove(id);
            if (person == null)
            {
                return RedirectToAction(nameof(People));
                //return NotFound();//404
            }
            else
            {
                _peopleService.Remove(id);
                
            }
            
            return View(); 
        }
        [HttpPost]
        public IActionResult People(string search)
        {
            if (search != null)
            {
                return View(_peopleService.Search(search));
            }
            return RedirectToAction(nameof(People));
        }

        //**********************************// AJAX //*******************************************//
        public IActionResult PartialViewPeople()
        {
            return PartialView("_PeopleList", _peopleService.All());
        }
        [HttpPost]
        public IActionResult PartialViewDetails(int id)
        {
            Person person = _peopleService.FindById(id);
            if (person != null)
            {
                return PartialView("_PersonDetails", person);
            }
            return NotFound();
        }
        public IActionResult AjaxDelete(int id)
        {
            Person person = _peopleService.FindById(id);
            if (_peopleService.Remove(id))
            {
                return PartialView("_PeopleList", _peopleService.All());
            }
            return NotFound();
        }

    }//End of Class name
}//End of namespace
