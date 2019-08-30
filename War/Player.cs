using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Player
    {
        public string Name { get; }

        public bool HasAmmo { get; private set; }

        public bool OpponentHasAmmo { get; private set; }

        public int BlockStreak { get; private set; }

        public int ReflectStreak { get; private set; }

        public bool IsComputer { get; }

        private List<Move> _PossibleMoves;

        private Random _random;

        public Player(string name, bool isComputer)
        {
            Name = name;
            HasAmmo = false;
            OpponentHasAmmo = false;
            BlockStreak = 0;
            ReflectStreak = 0;
            IsComputer = isComputer;
            _PossibleMoves = new List<Move> { Move.Load, Move.Shoot, Move.Block, Move.Reflect };
            _random = new Random();
        }

        public Move ChooseMove(bool firstMove = false)
        {
            if (firstMove)
            {
                return Move.Load;
            }

            var values = _PossibleMoves.ToList();
            
            if (HasAmmo)
            {
                values.Remove(Move.Load);
            }
            else
            {
                values.Remove(Move.Shoot);
            }

            if (!OpponentHasAmmo || BlockStreak >= 5)
            {
                values.Remove(Move.Block);
            }
            if (!OpponentHasAmmo || ReflectStreak >= 3)
            {
                values.Remove(Move.Reflect);
            }

            var r = _random.Next(values.Count);
            return values[r];
        }

        public void RecordMove(Move playerMove, Move opponentMove)
        {
            UpdateStats(playerMove);
            OpponentStats(opponentMove);
        }

        private void UpdateStats(Move move)
        {
            switch(move)
            {
                case Move.Load:
                    HasAmmo = true;
                    BlockStreak = 0;
                    ReflectStreak = 0;
                    break;
                case Move.Shoot:
                    HasAmmo = false;
                    BlockStreak = 0;
                    ReflectStreak = 0;
                    break;
                case Move.Block:
                    BlockStreak++;
                    ReflectStreak = 0;
                    break;
                case Move.Reflect:
                    BlockStreak = 0;
                    ReflectStreak++;
                    break;
            }
        }

        private void OpponentStats(Move move)
        {
            switch (move)
            {
                case Move.Load:
                    OpponentHasAmmo = true;
                    break;
                case Move.Shoot:
                    OpponentHasAmmo = false;
                    break;
                default:
                    break;
            }
        }
    }
}
