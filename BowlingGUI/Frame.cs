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
		private Class1 pt;
        private int scoreWorp1;
        private int scoreWorp2;
        private bool isStrike = false;
        private bool isSpare = false;
		private int totaleScoreWorp;

        public Frame(int scoreWorp1, bool isStrike, Class1 pt)
        {
            this.scoreWorp1 = scoreWorp1;
            this.isStrike = isStrike;
        }

        public Frame(int scoreWorp1, int scoreWorp2, Class1 pt)
        {
            this.scoreWorp1 = scoreWorp1;
            this.scoreWorp2 = scoreWorp2;
			if((scoreWorp1 + scoreWorp2) == 10){
				this.isSpare = true;
			}
        }

        private void BerekenScore()
        {
            if (!isSpare)
            {
                totaleScoreWorp = this.scoreWorp1 + this.scoreWorp2;
            }
            if (isSpare)
            {
                totaleScoreWorp = this.scoreWorp1 + this.scoreWorp2 + scoreLijst[worpNummer - 1];
            }
            if (isStrike)
            {
                totaleScoreWorp = this.scoreWorp1 + 10;
            }
            scoreLijst.Add(totaleScoreWorp);
            isSpare = false;
            isStrike = false;
            this.worpNummer++;
        }
		
		private void VoegScoreToeAanPuntentelling(){
			this.pt = pt;
			pt(totaleScoreWorp, isStrike, isSpare);
		}
    }
}
