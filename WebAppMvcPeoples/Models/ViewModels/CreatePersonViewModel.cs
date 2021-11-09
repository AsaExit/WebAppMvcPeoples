using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string City{ get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public List<string> CityList {
            get
            {
                return new List<string>
                {
                    "Växjö","Karlskrona", "Boden","Kirunna"
                };
            } 
        }
    }// End of class name
}// End of namespace
