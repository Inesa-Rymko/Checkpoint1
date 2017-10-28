using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
    public class Marshmallow : Sweet
    {
        public TasteMarshmallow taste;

        public Marshmallow(string marshmallowName, double marshmallowWeight, double marshmallowSugar, int marshmallowCount, TasteMarshmallow taste)
            : base(marshmallowName, marshmallowWeight, marshmallowSugar, marshmallowCount)
        {
            this.taste = taste;
        }
        public override void TypeSweet()
        {
            Console.WriteLine(taste.ToString());
        }
     
    }
}