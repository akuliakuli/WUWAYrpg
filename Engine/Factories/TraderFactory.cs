using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader elzar = new Trader("Elzar");
            elzar.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            Trader farmerTed = new Trader("Farmer Brook");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            Trader herbTheHerbalist = new Trader("Herbert the Herbalist");
            herbTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            AddTraderToList(elzar);
            AddTraderToList(farmerTed);
            AddTraderToList(herbTheHerbalist);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
