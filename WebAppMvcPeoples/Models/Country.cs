using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class Country
    {
        
        public List<City> Cities { get; set; }//Navigation Property

        public Country(string countryname)
        {
            CountryName = countryname;
        }
        public Country()// Empty constructor
        {

        }
        [Key]
        public int CountryId { get; }
        [StringLength(80, MinimumLength = 1)]
        public string CountryName
        {
            get; set;
        }
    }
}
