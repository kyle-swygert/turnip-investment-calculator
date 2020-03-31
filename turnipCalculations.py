# Turnip Investment Calculator for Animal Crossing Stalk Market!

import sys
import decimal

class Turnip:

    purchasePrice = 0
    sellingPrice = 0
    unitsPurchased = 0

    def __init__(self, purchasePrice, sellingPrice, unitsPurchased):
        self.purchasePrice = purchasePrice
        self.sellingPrice = sellingPrice
        self.unitsPurchased = unitsPurchased
        self.displayInvestmentStats()

    def calcInitInvestment(self):
        return self.purchasePrice * self.unitsPurchased

    def calcPerTurnipGain(self):
        return self.sellingPrice - self.purchasePrice

    def calcTotalGain(self):
        return self.calcPerTurnipGain() * self.unitsPurchased

    def calcTotalReturn(self):
        return self.sellingPrice * self.unitsPurchased

    def calcPercentGain(self):
        return ((self.sellingPrice - self.purchasePrice) / (self.purchasePrice)) * 100

    def displayInvestmentStats(self):
        print('Turnip Investment Calculations: ')
        print(f'Purchase Price:     {self.purchasePrice}')
        print(f'Selling Price:      {self.sellingPrice}')
        print(f'Units Purchased:    {self.unitsPurchased}')
        print(f'PerTurnipGain:      {self.calcPerTurnipGain()}')
        print(f'Initial Investment: {self.calcInitInvestment()}')
        print(f'Total Return:       {self.calcTotalReturn()}')
        print(f'Total Gain:         {self.calcTotalGain()}')
        print(f'Percent Gain:       {self.calcPercentGain()}%')

if __name__ == "__main__":
    # run the program with the command line arguments
    if len(sys.argv) == 4:
        test = Turnip(int(sys.argv[1]), int(sys.argv[2]), int(sys.argv[3]))
    else:
        print("Incorrect number of command line arguments given to program.")