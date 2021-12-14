using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CountryViewModel:CreateCountryViewModel
    {
        public List<Country>CountryListView { get; set; }

        public string FilterString { get; set; }
        public CountryViewModel()
        {
            CountryListView = new List<Country>();
        }
    }
}
