using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models.Repos;
using WebAppMvcPeoples.Models.ViewModels;

namespace WebAppMvcPeoples.Models.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepo _cityRepo;

        public CityService(ICityRepo cityRepo)
        {
            _cityRepo = cityRepo;
        }
        public City Add(CreateCityViewModel cityViewModel)
        {
            City createCity = _cityRepo.Create(cityViewModel.CityName);
            return createCity;
        }

        public CityViewModel All()
        {
            CityViewModel findAllCities = new CityViewModel() { CityListView = _cityRepo.Read() };
            return findAllCities;
        }

        public CityViewModel FindBy(CityViewModel search)
        {
            search.CityListView.Clear();
            //
            foreach (City item in _cityRepo.Read())
            {
                if (item.CityName.Contains(search.FilterString, StringComparison.OrdinalIgnoreCase))
                {
                    search.CityListView.Add(item);
                }
            }
            //searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper()) || p.City.Contains(search.ToUpper())).ToList();
            if (search.CityListView.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return search;
        }

        public City FindById(int Id)
        {
            City cityFound = _cityRepo.Read(Id);
            return cityFound;
        }
        public bool Edit(int Id, CreateCityViewModel editCity)
        {
            City orginalCountry = FindById(Id);
            if (orginalCountry == null)
            {
                return false;
            }
            orginalCountry.CityName = editCity.CityName;
            return _cityRepo.Update(orginalCountry);
        }
        public bool Remove(int Id)
        {
            City cityToDelete = _cityRepo.Read(Id);
            bool succses = _cityRepo.Delete(cityToDelete);
            return succses;
        }
    }

}

