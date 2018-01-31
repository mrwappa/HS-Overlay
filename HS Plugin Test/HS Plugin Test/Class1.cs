using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;
using Hearthstone_Deck_Tracker.Enums.Hearthstone;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;
using Hearthstone_Deck_Tracker.Properties;
using Hearthstone_Deck_Tracker.Live;
using Hearthstone_Deck_Tracker;
using Hearthstone_Deck_Tracker.Stats;
using Hearthstone_Deck_Tracker.Windows;
using Hearthstone_Deck_Tracker.Enums;

namespace HS_TEST
{
    public class Class1
    {
        internal static void TurnStart(ActivePlayer player)
        {

        }

        internal static void GameStart()
        {
        }
    }

    public class Class1Plugin : IPlugin
    {
        GameV2 game = new GameV2();
        DeckManager deckManager = new DeckManager();
        GameEvents gameEvents = new GameEvents();
        public void OnLoad()
        {
            //when it's loaded upon each restart/turned on by the user
            GameEvents.OnGameStart.Add(Class1.GameStart);
            GameEvents.OnTurnStart.Add(Class1.TurnStart);
        }

        public void OnUnload()
        {
            // handle unloading here. HDT does not literally unload the assembly
        }

        public void OnButtonPress()
        {
            //when user presses the menu button
        }

        public void OnUpdate()
        {
            if(game.IsMulliganDone)
            {

            }
            // called every ~100ms
        }

        public string Name => "PLUGIN NAME";

        public string Description => "DESCRIPTION";

        public string ButtonText => "BUTTON TEXT";

        public string Author => "AUTHOR";

        public Version Version => new Version(0, 0, 1);

        public MenuItem MenuItem => null;
    }
}
