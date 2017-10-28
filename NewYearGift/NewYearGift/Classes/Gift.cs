using NewYearGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift.Classes
{
    public class Gift : IGift
    {
        public ICollection<Sweet> items = new List<Sweet>();

        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }

        public double GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.Weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Sweet> FindCandyBySugar(double a, double b)
        {
            return items.Where(x => (x.Sugar >= a) && (x.Sugar <= b));
        }

        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }
    }
}
