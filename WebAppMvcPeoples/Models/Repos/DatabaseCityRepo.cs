using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Data;

namespace WebAppMvcPeoples.Models.Repos
{
    public class DatabaseCityRepo : ICityRepo
    {
        readonly PeopleDbContext _cityListContext;
        public DatabaseCityRepo(PeopleDbContext cityListContext)
        {
            _cityListContext = cityListContext;
        }
        public City Create(string cityname)
        {
            City newCity = new City(cityname);
            _cityListContext.Add(newCity);
            _cityListContext.SaveChanges();
            return newCity;
        }

        public List<City> Read()
        {
            List<City> cityList = _cityListContext.Cities.ToList();
            return cityList;
        }

        public City Read(int Id)
        {
            return _cityListContext.Cities.Find();
        }

        public bool Update(City city)
        {
            _cityListContext.Cities.Update(city);
            int resultUp=_cityListContext.SaveChanges();
            if (resultUp > 0)
            {
                return true;
            }
            return false;
            

        }
        public bool Delete(City city)
        {
            _cityListContext.Cities.Remove(city);
            int resultDel = _cityListContext.SaveChanges();
            if (resultDel > 0)
            {
                return true;
            }
            return false;
        }
    }
}

