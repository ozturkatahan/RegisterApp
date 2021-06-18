using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class CountryController : BaseController<Country, EfCoreCountryRepository>
    {
        public CountryController(EfCoreCountryRepository repository) : base(repository)
        {

        }
    }
}
