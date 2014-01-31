using System;
using System.Collections.Generic;

namespace Battlemeister.RealmStatus
{
    public class RealmResponse
    {
        public IEnumerable<RealmStatus> Realms { get; set; }
    }

    public class PvpArea
    {
        public int Area { get; set; }
        public int ControllingFaction { get; set; }
        public int Status { get; set; }
        public Int64 Next { get; set; }
    }

    public class RealmStatus
    {
        public string Type { get; set; }
        public string Population { get; set; }
        public bool Queue { get; set; }
        public PvpArea WinterGrasp { get; set; }
        public PvpArea TolBarad { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Battlegroup { get; set; }
        public string Locale { get; set; }
        public string Timezone { get; set; }
    }
}