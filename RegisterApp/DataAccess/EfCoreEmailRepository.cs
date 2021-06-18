using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreEmailRepository : EfCoreRepository<Email, RegisterContext>
    {
        public EfCoreEmailRepository(RegisterContext context) : base(context)
        {

        }
    }
}
