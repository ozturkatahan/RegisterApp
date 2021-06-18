using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreTelephoneRepository : EfCoreRepository<Telephone, RegisterContext>
    {
        public EfCoreTelephoneRepository(RegisterContext context) : base(context)
        {

        }
    }
}
