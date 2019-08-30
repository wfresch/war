using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Game
    {
        public Player[] Players;
        private int[,] _outcomeMatrix;

        public Game(string playerName)
        {
            Player player1 = new Player(playerName, false);
            Player player2 = new Player("Compy", true);
            Players = new Player[2] { player1, player2 };

            _outcomeMatrix = new int[4, 4] { { 0, 2, 0, 0 }, { 1, 0, 0, 2 }, { 0, 0, 0, 0 }, { 0, 1, 0, 0 } };
        }

        public int CompareMoves(Move move1, Move move2)
        {
            int row = (int)move1;
            int column = (int)move2;

            return _outcomeMatrix[row, column];
        }

        public Player GetPlayer(int player)
        {
            return Players[player];
        }


    }
}
