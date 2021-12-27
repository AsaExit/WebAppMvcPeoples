using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMvcPeoples.Models
{// the blueprint of a Person or my person dataModel

    public class Person
    {
        public Person()
        {}
        [Key]
        public int PersonId { get; set; }// Key
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }// PeopleDbContext and foreignKey
        public  City City { get; set; }

        public List<PersonLanguage> PersonLanguages { get; set; }//Navigation Property

    }//End of Person Class
}//End of namespace
