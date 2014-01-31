using System;
using System.Collections.Generic;

namespace Battlemeister.AuctionInformation
{
    public class AuctionRealmInformation
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }

    public class AuctionListing
    {
        public IEnumerable<AuctionItem> Auctions { get; set; }
    }

    public class AuctionItem
    {
        public Int64 Auc { get; set; }
        public int Item { get; set; }
        public string Owner { get; set; }
        public string OwnerRealm { get; set; }
        public int Bid { get; set; }
        public int Buyout { get; set; }
        public int Quantity { get; set; }
        public string TimeLeft { get; set; }
        public int Rand { get; set; }
        public Int64 Seed { get; set; }
    }

    public class FileInfoData
    {
        public string Url { get; set; }
        public Int64 LastModified { get; set; }
    }

    public class AuctionData
    {
        public IEnumerable<FileInfoData> Files { get; set; }
    }

    public class AuctionResponse
    {
        public AuctionRealmInformation RealmInformation { get; set; }

        public AuctionListing Alliance { get; set; }
        public AuctionListing Horde { get; set; }
        public AuctionListing Neutral { get; set; }
    }
}