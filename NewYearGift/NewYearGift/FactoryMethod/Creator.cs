using NewYearGift.Classes;
using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Sweet FactoryMethod(string candyName, double candyWeight, double candySugar, int candyCount, TypeCandy type);
        public abstract Sweet FactoryMethod(string coockieName, double cookieWeight, double cookieSugar, int cookieCount, TypeCoockie Coockie);
        public abstract Sweet FactoryMethod(string marshmallowName, double marshmallowWeight, double marshmallowSugar, int marshmallowCount, TasteMarshmallow taste);
    }
}
