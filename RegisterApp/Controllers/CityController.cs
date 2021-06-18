using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class CityController : BaseController<City, EfCoreCityRepository>
    {
        public CityController(EfCoreCityRepository repository) : base(repository)
        {

        }
    }
}
