using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
   public class Coockie: Sweet 
    {
        public TypeCoockie type;

        public Coockie(string coockieName, double coockieWeight, double coockieSugar, int coockieCount, TypeCoockie type)
            : base(coockieName, coockieWeight, coockieSugar, coockieCount)
        {
            this.type = type;
        }
        public override void TypeSweet()
        {
            Console.WriteLine(type.ToString());
        }
    }
}
