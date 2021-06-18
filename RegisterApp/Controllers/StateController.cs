using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class StateController : BaseController<State, EfCoreStateRepository>
    {
        public StateController(EfCoreStateRepository repository) : base(repository)
        {

        }
    }
}
