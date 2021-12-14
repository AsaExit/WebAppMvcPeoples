using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
   public interface ICityService
    {
        City Add(CreateCityViewModel person);

        CityViewModel All();

        CityViewModel FindBy(CityViewModel search);

        City FindById(int Id);

        bool Edit(int Id, CreateCityViewModel editCity);

        bool Remove(int Id);

    

    }
}
