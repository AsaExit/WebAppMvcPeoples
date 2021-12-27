using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
using WebAppMvcPeoples.Models.Services;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Controllers
{
    public class CityController : Controller
    {

        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;
        public CityController(ICityService cityService, ICountryService countryService)
        {
            _cityService = cityService;
            _countryService = countryService;
        }
   
        public IActionResult Index()
        {
            return View(_cityService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateCityViewModel model = new CreateCityViewModel();
            model.Countries = _countryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult FindCityById(int Id)
        {
            City foundCity = _cityService.FindById(Id);
            return View();
        }
    }
}
