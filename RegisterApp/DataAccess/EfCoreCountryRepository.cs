using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreCountryRepository : EfCoreRepository<Country, RegisterContext>
    {
        public EfCoreCountryRepository(RegisterContext context) : base(context)
        {

        }
    }
}
