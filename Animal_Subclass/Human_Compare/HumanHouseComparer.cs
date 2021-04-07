using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab04_Interfejsy.Animal_Subclass.Human_Compare
{
    class HumanHouseComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Homes.Count.CompareTo(y.Homes.Count);
        }
    }
}
