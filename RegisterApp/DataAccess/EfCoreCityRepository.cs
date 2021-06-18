using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreCityRepository : EfCoreRepository<City, RegisterContext>
    {
        public EfCoreCityRepository(RegisterContext context) : base(context)
        {

        }
    }
}
