using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{
    public class Country
    {
        private string _countryname;// _ "needel" String countryname

        public List<City> Cities { get; set; }//Navigation Property

        public Country(string countryname)
        {
            ConutryName = countryname;
        }
        public Country()// Empty constructor
        {

        }
        [Key]
        public int CountryId { get; }
        [StringLength(80, MinimumLength = 1)]
        public string ConutryName
        {
            get { return _countryname; }
            set { _countryname = value; }
        }
    }
}
