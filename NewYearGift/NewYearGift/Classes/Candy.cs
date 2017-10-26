using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
    public class Candy : Sweet
    {
        public TypeCandy type;

        public Candy(string candyName, double candyWeight, double candySugar, int candyCount, TypeCandy type)
            : base(candyName, candyWeight, candySugar, candyCount)
        {
            this.type = type;
        }
        public override void TypeSweet()
        {
            Console.WriteLine(type.ToString());
        }
    }
}
