using GraphQlDiplom.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDiplom.GraphQL
{
    public class MutationsAddOrder
    {
        public bool da = true;

        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public Order Addorder([Service] ApplicationContext ctx,int clientId, int stateId, DateTime creationDate, int phoneNumber)
        {
            Order order = new Order() { ClientId = clientId, CreationDate = creationDate, PhoneNumber = phoneNumber, StateId = stateId };
            //ctx.Add(order);
            
            ctx.Orders.Add(order);
            ctx.SaveChanges();
            return order;

            //(order:{ clientId: 3, creationDate: "22.02.2022", orderId: 10, phoneNumber: 43242, stateId: 2 }  )
        }
        public  Order AddItem([Service] ApplicationContext ctx, int orderId, Item item)
        {
            Order ord = ctx.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (ord == null) throw  new GraphQLException(new Error("Заказ не найден"));
                ord.Items.Add(item);
                ctx.Orders.Update(ord);

                return ord;

        }
        public bool Deleteorder([Service] ApplicationContext ctx, Order order, int orderId)
        {
            try
            {
                var or = ctx.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (or == null) return false;
                ctx.Remove(or);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public async Task<Client> CreateOrUpdate(Client client, [Service] ApplicationContext ctx, [Service] ITopicEventSender sender) 
        {
            if (client.ClientId == 0 || ctx.Clients.Any(a => a.ClientId == client.ClientId))
                ctx.Add(client);
            else
                ctx.Update(client);
            ctx.SaveChanges();

            await sender.SendAsync(nameof(Subscriptions.OnClientChanged), client);
            return client;
        }

    }







}
