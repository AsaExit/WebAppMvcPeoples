using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Data;

namespace WebAppMvcPeoples.Models.Repos
{
    public class DatabaseCityRepo : ICityRepo
    {
        readonly PeopleDbContext _peopleDbContext;
        public DatabaseCityRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }
        public City Create(City city)
        {
            
            _peopleDbContext.Cities.Add(city);
            _peopleDbContext.SaveChanges();
            return city;
        }

        public List<City> GetAll()
        {
             return _peopleDbContext.Cities.Include(city => city.Country).ToList();
             
        }

        public City FindById(int Id)
        {
            return _peopleDbContext.Cities.SingleOrDefault(city => city.CityId == Id);
        }

        public bool Update(City city)
        {
            _peopleDbContext.Cities.Update(city);
            int resultUp= _peopleDbContext.SaveChanges();
            if (resultUp > 0)
            {
                return true;
            }
            return false;
            

        }
        public bool Delete(City city)
        {
            _peopleDbContext.Cities.Remove(city);
            int resultDel = _peopleDbContext.SaveChanges();
            if (resultDel > 0)
            {
                return true;
            }
            return false;
        }
    }
}

