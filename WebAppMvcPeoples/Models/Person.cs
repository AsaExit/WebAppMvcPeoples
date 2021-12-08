using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models
{// the blueprint of a Person or my person dataModel

    public class Person
    {
        //private int personId;
        //private string name;
        //private string phonenumber;
        //private City city;

        public Person()
        {

        }
        public Person(string name,string phonenumber, string city)// Here to put in City class name
        {
            
            Name = name;
            PhoneNumber = phonenumber;
            City = city;
            
        }
        
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

    }//End of Person Class
}//End of namespace
