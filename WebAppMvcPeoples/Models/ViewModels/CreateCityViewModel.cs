using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreateCityViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Enter a city, it is Required!")]
        [StringLength(80, MinimumLength = 1)]
        [Display(Name ="City")]
        public string CityName { get; set; }
        public List<Person> PeopleList { get; set; }
        public int CountryId { get; set; }
        public List<Country> Countries { get; set; }

        public CreateCityViewModel() => Countries = new List<Country>();


    }
}
