using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using GraphQlDiplom.Models;

namespace GraphQlDiplom.GraphQL
{
    public class Subscriptions
    {
        [Subscribe]
        public Client OnClientChanged([EventMessage] Client client) => client;

    }
}
