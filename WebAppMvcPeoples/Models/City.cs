using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }// Key
        
        public City()//Empty constructor
        { }

        public City(string cityName) => CityName = cityName;
        [Required]
        [StringLength(80, MinimumLength = 1)]
        public string CityName { get; set;}
      
        [ForeignKey("Country")]
        public int CountryId { get; set; }// PeopleDbContext ForeignKey
        public Country Country { get; set; }//Navigation Property
        public List<Person> People { get; set; }//Navigation Property
        
    }
}
