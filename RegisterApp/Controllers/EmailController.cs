using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class EmailController : BaseController<Email, EfCoreEmailRepository>
    {
        public EmailController(EfCoreEmailRepository repository) : base(repository)
        {

        }
    }
}
