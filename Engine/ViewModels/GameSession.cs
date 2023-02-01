using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public GameSession() 
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Ninja";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.ExperiencePoints = 5;
            CurrentPlayer.Level = 1;
            CurrentPlayer.HitPoints = 5;
        }
    }
}
