using HotChocolate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDiplom.Models
{
    public class Item
    {
        [Key]
        [GraphQLIgnore]
        public int ItemId { get; set; }
        public int OwnerId { get; set; }
        public DateTime EventDate { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
    }
}
