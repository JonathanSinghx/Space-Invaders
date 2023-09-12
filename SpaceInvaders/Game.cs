using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Game
    {
        //PROPERTIES
        Player[] Player;
        //Round currentRound;
        bool initializeRound;

        //CONSTRUCTORS
        public Game()
        {
           this.InitializeRound = false;
        }

        //GETTERS AND SETTERS
        public Player[] Player1 { get => Player; set => Player = value; }
        public bool InitializeRound { get => initializeRound; set => initializeRound = value; }

        //METHODS

    }
}
