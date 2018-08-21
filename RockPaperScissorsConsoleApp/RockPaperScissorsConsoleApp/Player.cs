using System;

namespace RockPaperScissorsConsoleApp
{
    public class Player
    {
        public string name;
        public string chosenMove;

        public Player(string _name, string _chosenMove)
        {
            name = _name;
            chosenMove = _chosenMove;
        }
    }
}
