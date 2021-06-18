using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class Telephone : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [Phone(ErrorMessage ="Hatalı telefon numarası")]
        public string telNumber { get; set; }
    }
}
