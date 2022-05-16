using HotChocolate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDiplom.Models
{
    public class Client
    {
        [Key]
       //[GraphQLIgnore]
        public int ClientId { get; set; }
        public bool IsBlocked { get; set; }
        public int Deposit { get; set; }
        public int Bonus { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName {get;set;}
    }
}
