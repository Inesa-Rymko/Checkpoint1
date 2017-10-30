using NewYearGift.Classes;
using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.FactoryMethod
{
    public class CookieCreator : Creator
    {
        public override Sweet FactoryMethod(string cookieName, double cookieWeight, double cookieSugar, int cookieCout, TypeCoockie Coockie)
        {
            return new Coockie(cookieName, cookieWeight, cookieSugar, cookieCout, Coockie);
        }

        public override Sweet FactoryMethod(string candyName, double candyWeight, double candySugar, int candyCount, TypeCandy type)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string marshmallowName, double marshmallowWeight, double marshmallowSugar, int marshmallowCount, TasteMarshmallow taste)
        {
            throw new NotImplementedException();
        }
    }
}
