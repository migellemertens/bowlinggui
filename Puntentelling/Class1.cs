using System;
using System.Windows;
using System.Collections.Generic;

namespace Puntentelling
{
    public class Class1
    {
        private List<int> scoreLijst = new List<int>();
        private int totaleScoreWorp;
        private int scoreWorp;
        private bool isStrike = false;
        private bool isSpare = false;
        private int worpNummer = 0;

        public Class1(int scoreWorp, bool isStrike, bool isSpare)
        {
            this.scoreWorp = scoreWorp;
			this.isStrike = isStrike;
            this.isSpare = isSpare;

        }
		
		private void VoegScoreToeAanLijst(){
			if(isStrike == true && scoreLijst.Count() > 0){
				this.totaleScoreWorp = this.totaleScoreWorp + scoreLijst[worpNummer - 1];
			}
			if(isSpare == true && scoreLijst.Count() > 0){
				this.totaleScoreWorp = this.totaleScoreWorp + scoreLijst[worpNummer - 1];
			}
			
			ScoreLijst.Add(totaleScoreWorp);
			this.worpNummer++;
		}

    }
}
