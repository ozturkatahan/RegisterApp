using Microsoft.AspNetCore.Mvc;
using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterContext _db;

        public RegisterController(RegisterContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
