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
        private ICollection<Sweet> items;

        public Gift()
        {
            items = new List<Sweet>();
        }

        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }

        public double GiftWeight()
        {
            return items.Sum(x => x.weight);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Sweet> FindCandyBySugar(double m, double ma)
        {
            return items.Where(x => (x.sugar >= 70) && (x.sugar <= 100)).ToList();
        }

        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }
    }
}
