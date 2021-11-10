using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPerson);
        List<Person> GetAll();
        List<Person> FindByCity(string city);
        Person FindById(int id);
        //Person Edit(Person person);
        bool Edit(int id, CreatePersonViewModel editPerson);
        //bool Remove(Person person);
        bool Remove(int id);
       
    }// End of interface

}// End of namespace
