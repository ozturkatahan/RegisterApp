using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegisterApp.DataAccess;
using RegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class RegisterController : BaseController<Register, EfCoreRegisterRepository>
    {
        private readonly RegisterContext db;
       
        public RegisterController(EfCoreRegisterRepository repository) : base(repository)
        {
            
        }
        public IActionResult Index(int id, string name, string surname, string password)
        {
            IQueryable<Register> query = db.Register;
            query = query.Where(x => x.Id == id);
            query = query.Where(x => x.Name == name);
            query = query.Where(x => x.Surname == surname);
            query = query.Where(x => x.Password == password);
            ViewBag.Country = new SelectList(query.Select(x=>x.Country).ToList(), "Id", "countryName");
            ViewBag.City = new SelectList(query.Select(x=>x.City).ToList(), "Id", "cityName");
            ViewBag.State = new SelectList(query.Select(x=>x.States).ToList(), "Id", "stateName");
            ViewBag.Telephone = new SelectList(query.Select(x=>x.Telephone).ToList(), "Id", "telNumber");
            return View(query.ToList());
        }
        //public async Task<ActionResult<IEnumerable<Register>>> Register()
        //{
        //    return await _db.Register.ToListAsync();
        //}

        //[HttpGet]
        //public IActionResult Index(int id, string name, string surname, string password)
        //{
        //    using (var db = _db)
        //    {
        //        db.Cities.Where(x => x.Id == 1);
        //        ViewBag.Id = id;
        //        ViewBag.Name = name;
        //        ViewBag.Surname = surname;
        //        ViewBag.Password = password;
        //        ViewBag.Country = new SelectList(db.Countries.ToList(), "Id", "countryName");
        //        ViewBag.EmailAdress = new SelectList(db.Emails.ToList(), "Id", "EmailAdress");
        //        ViewBag.States = new SelectList(db.States.ToList(), "Id", "stateName");
        //        ViewBag.Telephone = new SelectList(db.Telephones.ToList(), "Id", "telNumber");
        //    }


        //    return View("Index");
        //}

        //[HttpPost]
        //public IActionResult Index(Register register)
        //{

        //    return View();
        //}
    }
}
