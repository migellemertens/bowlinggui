using System;
using System.Windows;
using System.Collections.Generic;

namespace Puntentelling
{
    public class Class1
    {
        private List<int> scoreLijst = new List<int>();
        private int totaleScoreWorp;
        private int scoreWorp1;
        private int scoreWorp2;
        private bool isStrike = false;
        private bool isSpare = false;
        private int worpNummer = 0;

        public Class1(int scoreWorp1, bool isStrike)
        {
            this.scoreWorp1 = scoreWorp1;
            isStrike = true;
        }

        public Class1(int scoreWorp1, int scoreWorp2, bool isSpare)
        {
            this.scoreWorp1 = scoreWorp1;
            this.scoreWorp2 = scoreWorp2;
            this.isSpare = true;

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
    }
}
