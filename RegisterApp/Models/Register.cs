using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Password { get; set; }
        public List<Country> Country { get; set; } = new List<Country>();
        public List<City> City { get; set; } = new List<City>();
        public List<Email> EmailAdress { get; set; } = new List<Email>();
        public List<State> States { get; set; }
        public List<Telephone> Telephone { get; set; } = new List<Telephone>();
    }
}
