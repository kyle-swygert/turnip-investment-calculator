using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipCalculator
{
    class Turnip
    {
        public int purchasePrice;
        public int sellingPrice;
        public int unitsPurchased;

        public Turnip(int purchasePrice, int sellingPrice, int unitsPurchased)
        {
            this.purchasePrice = purchasePrice;
            this.sellingPrice = sellingPrice;
            this.unitsPurchased = unitsPurchased;
        }

        public int calcInitInvestment()
        {
            return purchasePrice * unitsPurchased;
        }

        public int calcPerTurnipGain()
        {
            return sellingPrice - purchasePrice;
        }

        public int calcTotalGain()
        {
            return calcPerTurnipGain() * unitsPurchased;
        }

        public int calcTotalReturn()
        {
            return sellingPrice * unitsPurchased;
        }

        public double calcPercentGain()
        {
            var percentGain = ((((double)sellingPrice - (double)purchasePrice) / (double)(purchasePrice)) * 100);


            return percentGain;
        }

        public string generateCalculationResults()
        {
            return @"Turnip Investment Results:
PerTurnipGain:      " + this.calcPerTurnipGain() + @" 
Initial Investment: " + this.calcInitInvestment() + @"
Total Return:         " + this.calcTotalReturn() + @"
Total Gain:             " + this.calcTotalGain() + @"
Percent Gain:         " +  Math.Round(this.calcPercentGain(), 2) + @"%";
        }

    }
}
