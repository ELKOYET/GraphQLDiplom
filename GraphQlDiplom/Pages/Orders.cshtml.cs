using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GraphQlDiplom.Models;
using Microsoft.Extensions.Logging;

namespace GraphQlDiplom.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ILogger<OrdersModel> _logger;
        public GraphqlClient _graphclient;

        public List<Order> GetAllOrders;

        public OrdersModel(ILogger<OrdersModel> logger, GraphqlClient _graphclient)
        {
            _logger = logger;
            this._graphclient = _graphclient;
        }


        //public async Task  OnGet()
        //{
        //    var results = await _graphclient.GetAllOrders.ExecuteAsync();
        //    foreach (IGetAllOrders_ReadOrder  item in results.Data?.ReadOrder)
        //    {
        //        GetAllOrders =  item.Items[1].Product.Name;
        //    }

        //    GetAllOrders = results.Data.ReadOrder.Select(ord => new Order
        //    {
                
        //        Client client = new Client() {  FirstName =     GetAllOrders.},

        //        Client.FirstName = ord.Client,
        //        OrderId = ord.OrderId,
        //        Items = ord.Items,
        //        //Deposit = _.,
        //        PhoneNumber = ord.PhoneNumber

        //    }).ToList();
        //}
       
    }
}
