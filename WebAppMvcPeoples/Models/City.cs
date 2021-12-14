using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class City
    {
        public City()//Empty constructor
        { }
        public City(string cityname)
        {
            CityName = cityname;
        }
        [Key]
        public int CityId { get; }
        public List<Person> People { get; set; }//Navigation Property
        [StringLength(80, MinimumLength =1)]
        public string CityName
        {
            get; set;
        }

    }
}
