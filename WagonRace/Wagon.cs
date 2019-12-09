using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WagonRace
{
    class Wagon
    {
        public int startPos { get; set; }
        public int finalPos { get; set; }
        public PictureBox wagonImg { get; set; }
        private Random rand = new Random();

        // Checks if Jeep is in Motion
        public bool MoveWagon()
        {
            Point updatedLoc = wagonImg.Location;
            updatedLoc.X += rand.Next(1, 6);
            wagonImg.Location = updatedLoc;

            // Checks whether the location of right side of Jeep is same as final destination
            if (updatedLoc.X >= finalPos)
                return true;
            else
                return false;
        }

        public void BackToStartingPoint()
        {
            wagonImg.Left = startPos;
        }
    }
}
