using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
   public interface ICityService
    {
        City Create(CreateCityViewModel createCity);

        List<City> GetAll();

        List<City> FindBy(string search);

        City FindById(int id);

        bool Edit(int id, CreateCityViewModel cityViewModel);

        bool Remove(int id);

    

    }
}
