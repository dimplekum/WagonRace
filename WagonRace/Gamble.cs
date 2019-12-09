using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonRace
{
    class Gamble : Wagon
    {
        public int BetAmount { get; set; }
        public Competator gambler { get; set; }
        public int wagon { get; set; }
        public int rewardMultiplier = 4;

        public int CashOut(int winningJet)
        {
            if (winningJet == wagon)
                return BetAmount * rewardMultiplier;
            else
                return (0 - BetAmount);
        }
    }
}
