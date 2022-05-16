using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlDiplom.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace GraphQlDiplom.GraphQL
{
    public class Queries
    {
        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        //[UsePaging(IncludeTotalCount =true)]
        public IQueryable<Client> ReadClients([Service] ApplicationContext ctx) => ctx.Clients;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        
        public IQueryable<Item> ReadItems([Service] ApplicationContext ctx) => ctx.Items;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<ItemStatus> ReadCitemsStatus([Service] ApplicationContext ctx) => ctx.ItemStatuses;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<Order> ReadOrder([Service] ApplicationContext ctx) => ctx.Orders;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<Product> ReadProducts([Service] ApplicationContext ctx) => ctx.Products;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<GraphQlDiplom.Models.State> ReadStates([Service] ApplicationContext ctx) => ctx.States;



        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<Order> ReadOrderByCleint([Service] ApplicationContext ctx, IEnumerable<int> clientId) => ctx.Orders.Where(a => clientId.Contains(a.ClientId));

        [UseProjection]
        public IQueryable<Item> ReadList([Service] ApplicationContext ctx, int orderId) => ctx.Items.Where(a => a.OrderId == orderId);




    }
}
