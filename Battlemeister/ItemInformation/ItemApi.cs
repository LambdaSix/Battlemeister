using System;
using System.Collections.Generic;
using Battlemeister.RealmStatus;
using Newtonsoft.Json;

namespace Battlemeister.ItemInformation
{
    public class StatBonus
    {
        public int Amount { get; set; }
        public int Stat { get; set; }
    }

    public class SpellInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubText { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Range { get; set; }
        public string CastTime { get; set; }
        public string Cooldown { get; set; }
    }

    public class ItemSource
    {
        public int SourceId { get; set; }
        public string SourceType { get; set; }
    }

    public class ItemSpell
    {
        public int SpellId { get; set; }
        public SpellInfo Spell { get; set; }
        public int NumCharges { get; set; }
        public int Consumable { get; set; }
        public int CategoryId { get; set; }
    }

    public class ItemResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Stackable { get; set; }
        public int ItemBind { get; set; }
        public IEnumerable<StatBonus> BonusStats { get; set; }
        public IEnumerable<ItemSpell> ItemSpells { get; set; }
        public int BuyPrice { get; set; }
        public int ItemClass { get; set; }
        public int ItemSubClass { get; set; }
        public int ContainerSlots { get; set; }
        public int InventoryType { get; set; }
        public bool Equippable { get; set; }
        public int ItemLevel { get; set; }
        public int MaxCount { get; set; }
        public int MaxDurability { get; set; }
        public int MinFactionId { get; set; }
        public int MinReputation { get; set; }
        public int Quality { get; set; }
        public int SellPrice { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredLevel { get; set; }
        public int RequiredSkillRank { get; set; }
        public ItemSource ItemSource { get; set; }
        public int BaseArmor { get; set; }
        public bool HasSockets { get; set; }
        public bool IsAuctionable { get; set; }
        public int Armor { get; set; }
        public int DisplayInfoId { get; set; }
        public string NameDescription { get; set; }
        public string NameDescriptionColor { get; set; }
        public bool Upgradable { get; set; }
        public bool HeroicToolTip { get; set; }
    }

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