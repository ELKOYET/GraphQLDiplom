using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GraphQlDiplom.Models
{
    public class ItemStatus
    {
        [Key]
        public int ItemId { get; set; }
        public bool IsValid { get; set; }
        public bool IsActivated { get; set; }
     

    }
}
