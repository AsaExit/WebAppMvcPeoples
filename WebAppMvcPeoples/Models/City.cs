using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class City
    {
        private string _cityname;//_"needel" string name cityname

        public List<Person>People { get; set; }//Navigation Property
        public City()//Empty constructor
        {

        }
        public City(string cityname)
        {
            CityName = cityname;
        }
        [Key]
        public int CityId { get; }

        [StringLength(80, MinimumLength =1)]
        public string CityName
        {
            get { return _cityname; }
            set { _cityname = value; }
        }

    }
}
