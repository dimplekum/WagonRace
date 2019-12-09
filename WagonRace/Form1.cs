using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WagonRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Setup Defaults
            setup();
        }

        // Setup all the base elements for the race
        public void setup()
        {
            // Get's the start position
            int startPos = wagon_black.Left;

            // Calculates the length of the race track
            int RaceTrackLength = TrackLengthPanel.Width - wagon_black.Right;

            // Initializes all the racing vehicles
            DataStorage.wagon[0] = new Wagon() { wagonImg = wagon_black, startPos = startPos, finalPos = RaceTrackLength };
            DataStorage.wagon[1] = new Wagon() { wagonImg = wagon_red, startPos = startPos, finalPos = RaceTrackLength };
            DataStorage.wagon[2] = new Wagon() { wagonImg = wagon_blue, startPos = startPos, finalPos = RaceTrackLength };
            DataStorage.wagon[3] = new Wagon() { wagonImg = wagon_yellow, startPos = startPos, finalPos = RaceTrackLength };

            // Initialize all the gamblers
            DataStorage.bettor[0] = new Competator() { balance = 50, activity = label1, listOfBettors = radioButton1, name = "Player 1" };
            DataStorage.bettor[1] = new Competator() { balance = 50, activity = label2, listOfBettors = radioButton2, name = "Player 2" };
            DataStorage.bettor[2] = new Competator() { balance = 50, activity = label3, listOfBettors = radioButton3, name = "Player 3" };

            // Update all the activity labels to default
            DataStorage.bettor[0].UpdateActivity();
            DataStorage.bettor[1].UpdateActivity();
            DataStorage.bettor[2].UpdateActivity();

            // Reset all the starts to defaults
            DataStorage.bettor[0].ResetStats();
            DataStorage.bettor[1].ResetStats();
            DataStorage.bettor[2].ResetStats();
        }

        public void ResetPositions()
        {
            DataStorage.wagon[0].BackToStartingPoint();
            DataStorage.wagon[1].BackToStartingPoint();
            DataStorage.wagon[2].BackToStartingPoint();
            DataStorage.wagon[3].BackToStartingPoint();
        }

        public void ResetBidsText()
        {
            label1.Text = "Player 1 hasn't placed a bit.";
            label2.Text = "Player 2 hasn't placed a bit.";
            label3.Text = "Player 3 hasn't placed a bit.";
        }

        public void announceWinner(int winner)
        {
            MessageBox.Show("Wagon #" + winner + " is the winning Wagon!");
            for (int i = 0; i < DataStorage.bettor.Length; i++)
            {
                DataStorage.bettor[i].collectWinningAmount(winner);
                DataStorage.bettor[i].UpdateActivity();
                ResetPositions();
                ResetBidsText();
            }
        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            DataStorage.bettor[DataStorage.currentGambler].betting((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            DataStorage.bettor[DataStorage.currentGambler].UpdateActivity();
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            TickingTimer.Start();
            StartRace.Enabled = false;
        }

        private void TickingTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < DataStorage.wagon.Length; i++)
            {
                DataStorage.wagon[DataStorage.rand.Next(0, 4)].MoveWagon();
                if (DataStorage.wagon[i].MoveWagon())
                {
                    TickingTimer.Stop();
                    TickingTimer.Enabled = false;
                    StartRace.Enabled = true;
                    announceWinner(i + 1);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataStorage.currentGambler = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataStorage.currentGambler = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataStorage.currentGambler = 2;
        }

        private void TrackLengthPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
