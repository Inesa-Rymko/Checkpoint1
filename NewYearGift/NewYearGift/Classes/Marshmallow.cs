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
        public  double Sug { get; set; }
        
      
        public Marshmallow(string marshmallowName, double marshmallowWeight, double marshmallowSugar, int marshmallowCount, TasteMarshmallow taste)
            : base(marshmallowName, marshmallowWeight, marshmallowSugar, marshmallowCount)
        {
            this.taste = taste;
            Sug = marshmallowSugar;
        }
        public override void TypeSweet()
        {
            if ( Sug > 70)
            {
                Console.WriteLine("вкусная,  "+ "цвет конфетки: " + taste.ToString());
            }
            else
            {
                Console.WriteLine("не очень вкусная,  " + "цвет конфетки: " + taste.ToString());
            }
        }
    }
}