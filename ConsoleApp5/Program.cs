using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();                                 // Make new object from the Game Class Template
            game.Start();                                           // Tells the Class(Game) in this instance to use the .Start() Function.

        }
    }
}
