using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class PeopleViewModel:CreatePersonViewModel
    //Chained Constructors
    {
        public List<Person> PeopleListView { get; set; }
        public List<City> CityListView { get; set; }
        public string FilterString { get; set; }

        public PeopleViewModel()
        { PeopleListView = new List<Person>(); }
    }
}
