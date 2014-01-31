using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace Battlemeister.RealmStatus
{
    public class RealmStatusApi : IRealmStatusApi
    {
        private readonly IConfig _config;

        public RealmStatusApi(IConfig configuration)
        {
            _config = configuration;
        }

        // TODO: Add caching.

        public IEnumerable<RealmStatus> GetAll()
        {
            var client = new RestSharp.Http {Url = new Uri(_config.ApiUri + "/api/wow/realm/status")};

            var response = client.Get();

            return JsonConvert.DeserializeObject<RealmResponse>(response.Content).Realms;
        }
    }
}