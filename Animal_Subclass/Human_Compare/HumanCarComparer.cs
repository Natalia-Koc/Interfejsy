using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab04_Interfejsy.Animal_Subclass.Human_Compare
{
    class HumanCarComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Cars.Count.CompareTo(y.Cars.Count);
        }
    }
}
