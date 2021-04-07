using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab04_Interfejsy.Animal_Subclass.Human_Compare
{
    class MoneyHumanComparer : IComparer<Human>
    {
        int sumHousePriceX = 0, sumHousePriceY = 0;
        int sumCarPriceX = 0, sumCarPriceY = 0;
        public int Compare(Human x, Human y)
        {
            foreach (var item in x.Homes)
                sumHousePriceX += (int)item.Price;
            foreach (var item in y.Homes)
                sumHousePriceY += (int)item.Price;
            foreach (var item in x.Cars)
                sumCarPriceX += (int)item.Price;
            foreach (var item in y.Cars)
                sumCarPriceY += (int)item.Price;

            return (sumHousePriceX+sumCarPriceX).CompareTo(sumCarPriceY+sumHousePriceY);
        }
    }
}
