using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }   
        public GameSession() 
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Ninja";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 5;


            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(3, 0);
        }
    }
}
