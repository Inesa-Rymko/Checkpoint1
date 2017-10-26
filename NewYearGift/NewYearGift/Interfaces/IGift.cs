using NewYearGift.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Interfaces
{
   public interface IGift
    {
        IEnumerable<Sweet> Items { get; }
        void Add(Sweet sweets);
        double GiftWeight();
        void Sort();
        IEnumerable<Sweet> FindCandyBySugar(double min, double max); 
    }
}
