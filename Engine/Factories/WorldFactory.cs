using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Field",
                "This field have not seen good harvest for years",
                "pack://application:,,,/Engine;component/Images/Locations/Fields.png");
            newWorld.AddLocation(-1, -1, "Brook's House",
                "Best place to drink is at your friends house,dont have to clean the mess after",
                "pack://application:,,,/Engine;component/Images/Locations/Farm.png");
            newWorld.AddLocation(0, -1, "Home",
                "Sweet Home,dont forget to leave the comfort zone once in 30 minutes",
                "pack://application:,,,/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-1, 0, "Elzar's moving shop",
                "Place where prices dont bite,but owner's do",
                "pack://application:,,,/Engine;component/Images/Locations/Seller.png");
            newWorld.AddLocation(0, 0, "Town square",
                "Center of this beautiful city",
                "pack://application:,,,/Engine;component/Images/Locations/CityCentre.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                "No trespassing.",
                "pack://application:,,,/Engine;component/Images/Locations/DragonGate.png");
            newWorld.AddLocation(2, 0, "Northern light Forest",
                "The wonder of nature,no human words can describe the beauty of it",
                "pack://application:,,,/Engine;component/Images/Locations/NorthernLightForest.png");
            newWorld.AddLocation(0, 1, "Hut of Herb",
                "Cozy hut,example of eco-architechture",
                "pack://application:,,,/Engine;component/Images/Locations/HutOfHerb.png");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "Blossoming garden hiding the dangers of nature",
                "pack://application:,,,/Engine;component/Images/Locations/LateBloomGarden.png");
            newWorld.AddLocation(3, 0, "Western Border",
               "Western border of this nagluka country",
               "pack://application:,,,/Engine;component/Images/Locations/WesternBorder.png");
            return newWorld;
        }
    }
}
