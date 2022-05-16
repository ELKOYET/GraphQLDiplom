using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GraphQlDiplom.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string Name { get; set; }
    }
}
