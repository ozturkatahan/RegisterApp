using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class Email : IEntity
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage ="Geçersiz e-mail adresi.")]
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string EmailAdress { get; set; }
    }
}
