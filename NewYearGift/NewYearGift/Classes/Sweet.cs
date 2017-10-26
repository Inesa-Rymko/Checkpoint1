using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
    public abstract class Sweet
    {
        public string name { get; private set; }
        public double weight { get; private set; }
        public double sugar { get; private set; }
        public int pieceCount { get; set; }

        public Sweet(string sweetName, double sweetWeight, double sweetSugar, int sweetCount)
        {
            this.name = sweetName;
            this.weight = sweetWeight;
            this.sugar = sweetSugar;
            this.pieceCount = sweetCount;

        }

        public abstract void TypeSweet();
    }
}

