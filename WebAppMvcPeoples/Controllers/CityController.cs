using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
using WebAppMvcPeoples.Models.Services;

namespace WebAppMvcPeoples.Controllers
{
    public class CityController : Controller
    {

        private readonly ICityService _cityService;
        //private readonly ICountryService _countryService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllCityList()
        {
            List<City> cityList = _cityService.All().CityListView;
            return View();
        }
        [HttpPost]
        public IActionResult FindCityById(int Id)
        {
            City foundCity = _cityService.FindById(Id);
            return View();
        }
    }
}
