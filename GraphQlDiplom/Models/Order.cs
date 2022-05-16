using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace GraphQlDiplom.Models
{
    public class Order
    {

        
    [Key]     
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int StateId { get; set; }
    public DateTime CreationDate { get; set; }
    public int PhoneNumber { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();
    [GraphQLIgnore]
    public double TotalPrice => Items.Sum(x => x.Count * x.Product.Price);


}
}
