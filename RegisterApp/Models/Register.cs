using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public List<Country> Country { get; set; } = new List<Country>();
        public List<City> City { get; set; } = new List<City>();
        public List<Email> EmailAdress { get; set; } = new List<Email>();
        public List<Telephone> Telephone { get; set; } = new List<Telephone>();
    }
}
