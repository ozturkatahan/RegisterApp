using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class City : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan zorunludur!")]
        public string cityName { get; set; }
        public List<State> States { get; set; }
    }
}
