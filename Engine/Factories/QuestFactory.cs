﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));
            _quests.Add(new Quest(1,
                                  "Clear the herb garden",
                                  "If anything moves and tries to kill you, dont be afraid try to kill it back",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            _quests.Add(new Quest(
                    2,
                    "Fight the ancient spider in field",
                    "Try to defeat the old spider which been terrifying the city",
                    itemsToComplete,
                    25, 100,
                    rewardItems
                ));
        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
