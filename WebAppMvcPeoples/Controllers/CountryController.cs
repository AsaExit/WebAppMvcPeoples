using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.Services;

namespace WebAppMvcPeoples.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(_countryService.GetAll());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }


    }
}
