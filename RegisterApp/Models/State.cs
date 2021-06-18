using RegisterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Models
{
    public class State : IEntity
    {
        public int Id { get; set; }
        public string stateName { get; set; }
    }
}
