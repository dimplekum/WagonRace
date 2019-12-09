using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WagonRace
{
    class Competator : Gamble
    {
        public string name { get; set; }
        public int balance { get; set; }
        public Gamble currentBet;

        public RadioButton listOfBettors { get; set; }
        public Label activity { get; set; }

        public void UpdateActivity()
        {
            listOfBettors.Text = name + " has $" + balance;
        }

        public void ResetStats()
        {
            currentBet = null;
            activity.Text = name + " has't placed a bet.";
        }

        public bool betting(int amount, int bittingWagon)
        {
            this.currentBet = new Gamble() { BetAmount = amount, wagon = bittingWagon };

            if (amount <= balance)
            {
                balance -= amount;
                activity.Text = this.name + " has placed $" + amount + " on Wagon #" + bittingWagon;
                this.UpdateActivity();
                return true;
            }
            else
            {
                MessageBox.Show(this.name + " doesn't have enough money to cover for the bet!");
                this.currentBet = null;
                return false;
            }
        }

        public void collectWinningAmount(int winner)
        {
            if (this.currentBet != null)
            {
                balance += currentBet.CashOut(winner);
                ResetStats();
                UpdateActivity();
            }
        }
    }
}
