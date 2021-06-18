using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreRegisterRepository : EfCoreRepository<Register, RegisterContext>
    {
        public EfCoreRegisterRepository(RegisterContext context) : base(context)
        {

        }
    }
}
