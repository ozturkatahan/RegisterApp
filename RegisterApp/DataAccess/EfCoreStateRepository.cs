using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.DataAccess
{
    public class EfCoreStateRepository : EfCoreRepository<State, RegisterContext>
    {
        public EfCoreStateRepository(RegisterContext context) : base(context)
        {

        }
    }
}
