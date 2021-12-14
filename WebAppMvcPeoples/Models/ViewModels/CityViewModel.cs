using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CityViewModel:CreateCityViewModel
    {
        public List<City> CityListView { get; set; }
        public string FilterString { get; set; }
        
        public CityViewModel()
        {
            CityListView = new List<City>();
        }
    }

}
