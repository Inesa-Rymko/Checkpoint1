using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
    public abstract class Sweet
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double Sugar { get; private set; }
        public int PieceCount { get; set; }

        public Sweet(string sweetName, double sweetWeight, double sweetSugar, int sweetCount)
        {
            this.Name = sweetName;
            this.Weight = sweetWeight;
            this.Sugar = sweetSugar;
            this.PieceCount = sweetCount;

        }

        public abstract void TypeSweet();
    }
}

