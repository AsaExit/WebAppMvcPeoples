using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreatePersonViewModel
    {

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "PhoneNumber")]
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        public List<string> CityList
        {
            get
            {
                return new List<string>
                {
                    "Karlskrona",
                    "Kirunna",
                    "Boden",
                    "Borås",
                    "Gävle",
                    "Umeå",
                    "Lund",
                    "JönKöping",
                    "Norrköping",
                    "Helsihgborg",
                    "Linköping",
                    "Örebro",
                    "Västerås",
                    "Växjö",
                    "Upplands",
                    "Väsby",
                    "Sollentuna",
                    "Södertälje",
                    "Uppsala",
                    "Malmö",
                    "Göteborg",
                    "Stockholm"
                };

            }
        }
    }// End of class name
}// End of namespace
