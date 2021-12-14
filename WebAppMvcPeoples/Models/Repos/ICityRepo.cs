using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcPeoples.Models.Repos
{
    public interface ICityRepo
    {
        City Create(string cityname);
        List<City> Read();
        City Read(int Id);

        bool Update(City city);
        bool Delete(City city);
    }

}
