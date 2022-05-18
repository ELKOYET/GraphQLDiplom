using GraphQlDiplom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDiplom.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public GraphqlClient _graphclient;

        public List<Client> GetAllClients;

        public IndexModel(ILogger<IndexModel> logger, GraphqlClient _graphclient)
        {
            _logger = logger;
            this._graphclient = _graphclient;
        }

        public async Task OnGet()
        {
            // GetAllClients = new List<Client>();
            var results = await _graphclient.GetAllClients.ExecuteAsync();

            GetAllClients = results.Data.ReadClients.Select(_ => new Client
            {
                FirstName = _.FirstName,
                LastName = _.LastName,
                Email = _.Email,
                //Deposit = _.,
                PhoneNumber = _.PhoneNumber

            }).ToList();
        }
        //public async Task OnPost()
        //{
        //    var results = await _graphclient.GetAllClients.ExecuteAsync();

        //    GetAllClients = results.Data.ReadClients.Select(_ => new Client
        //    {
        //        FirstName = _.FirstName,
        //        LastName = _.LastName,
        //        Email = _.Email,
        //        //Deposit = _.,
        //        PhoneNumber = _.PhoneNumber

        //    }).ToList();
        //}
    }
}
