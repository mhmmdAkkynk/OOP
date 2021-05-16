using GameSellingSimulation.Abstract;
using GameSellingSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation.Concrete
{
    class GameManager : IGameService
    {
        public void Save(Game game)
        {
            Console.WriteLine("The game named " + game.GameName + " has been added to game list!");
        }

        public void Update(Game game)
        {
            Console.WriteLine("The game named " + game.GameName + " has been updated!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("The game named" + game.GameName + " has been deleted from the game list!");
        }

    }
}
