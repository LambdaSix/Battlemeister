using System;
using Battlemeister.RealmStatus;
using Newtonsoft.Json;

namespace Battlemeister.ItemInformation
{
    public class ItemApi
    {
        // http://us.battle.net/api/wow/item/99206 is the highest item ID (31-01-2014)
        private readonly IConfig _config;

        public ItemApi(IConfig configuration)
        {
            _config = configuration;
        }

        public ItemResponse Get(int itemId)
        {
            var client = new RestSharp.Http {Url = new Uri(_config.ApiUri + String.Format("api/wow/item/{0}", itemId))};

            var response = client.Get();

            return JsonConvert.DeserializeObject<ItemResponse>(response.Content);
        }
    }
}