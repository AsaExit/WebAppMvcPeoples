using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [StringLength(80, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "First and last name")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(80, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        [Required]
        public int CityId{ get; set; }

        public List<City> CityList { get; set; }
    }// End of class name
}// End of namespace
