using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class TelephoneController : BaseController<Telephone, EfCoreTelephoneRepository>
    {
        public TelephoneController(EfCoreTelephoneRepository repository) : base(repository)
        {

        }
    }
}
