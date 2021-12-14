using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Enter a country, it is Required!")]
        [StringLength(80, MinimumLength =1)]
        [Display(Name = "Country")]

        public string CountryName { get; set; }
    }
}
