using NewYearGift.Classes;
using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.FactoryMethod
{
    public class MarshmallowCreator : Creator
    {
        public override Sweet FactoryMethod(string marshmallowName, double marshmallowWeight, double marshmallowSugar, int marshmallowCount, TasteMarshmallow taste)
        {
            return new Marshmallow(marshmallowName, marshmallowWeight, marshmallowSugar, marshmallowCount, taste);
        }

        public override Sweet FactoryMethod(string candyName, double candyWeight, double candySugar, int candyCount, TypeCandy type)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string coockieName, double cookieWeight, double cookieSugar, int cookieCount, TypeCoockie Coockie)
        {
            throw new NotImplementedException();
        }
    }
}
