using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puntentelling;

namespace BowlingGUI
{
    public class Frame
    {

        private int scoreWorp1;
        private int scoreWorp2;
        private bool isStrike = false;
        private bool isSpare = false;

        public Frame(int scoreWorp1, bool isStrike, Class1 pt)
        {
            this.scoreWorp1 = scoreWorp1;
            this.isStrike = isStrike;
        }

        public Frame(int scoreWorp1, int scoreWorp2, Class1 pt)
        {
            this.scoreWorp1 = scoreWorp1;
            this.scoreWorp2 = scoreWorp2;
        }

        
    }
}
