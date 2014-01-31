using System;
using System.Collections.Generic;
using System.Linq;
using Battlemeister.ItemInformation;
using Newtonsoft.Json;

namespace Battlemeister.AuctionInformation
{
    public class AuctionApi
    {
        private readonly IConfig _config;

        public AuctionApi(IConfig configuration)
        {
            _config = configuration;
        }

         public AuctionResponse Get(string realmName)
         {
             var client = new RestSharp.Http { Url = new Uri(_config.ApiUri + String.Format("api/wow/auction/data/{0}", realmName)) };

             var dataResponse = client.Get();

             var data = JsonConvert.DeserializeObject<AuctionData>(dataResponse.Content);

             client.Url = new Uri(data.Files.First().Url);

             var response = client.Get();
             return JsonConvert.DeserializeObject<AuctionResponse>(response.Content);
         }

        public AuctionListing GetAlliance(string realmName)
        {
            return Get(realmName).Alliance;
        } 

        public AuctionListing GetHorde(string realmName)
        {
            return Get(realmName).Horde;
        }

        public AuctionListing Neutral(string realmName)
        {
            return Get(realmName).Neutral;
        }
    }
}