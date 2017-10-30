using NewYearGift.Classes;
using NewYearGift.FactoryMethod;
using NewYearGift.Interfaces;
using NewYearGift.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearGift
{
    public static class Extension
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine("Новогодний подарок: ");
            foreach (var i in gift.Items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Сахар: {2}, Кол-во: {3}"
                    , i.Name, i.Weight, i.Sugar, i.PieceCount);

            }
        }
    }
        class Program
        {

            static void Main(string[] args)
            {
                Creator[] creators = new Creator[3];
                creators[0] = new CandyCreator();
                creators[1] = new CookieCreator();
                creators[2] = new MarshmallowCreator();

                IGift gift = new Gift();

                foreach (Creator i in creators)
                {
                    if (i is CandyCreator)
                    {
                        gift.Add(i.FactoryMethod("Mars", 80, 105, 1, TypeCandy.ChocolateCandy));
                        gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 2, TypeCandy.Lollipop));
                    }

                    if (i is CookieCreator)
                    {
                        gift.Add(i.FactoryMethod("Chico-pia", 100, 115, 4, TypeCoockie.biscuit));
                    }

                    if (i is MarshmallowCreator)
                    {
                        gift.Add(i.FactoryMethod("Marshmallow", 230, 76.6f, 1, TasteMarshmallow.Orange));

                    }
                }

                gift.Sort();
                gift.ShowItems();

            Console.WriteLine();
            Console.WriteLine("вкусность конфетки");

            Marshmallow marshmallowsweet = new Marshmallow("Marshmallow", 230, 76.6f, 1, TasteMarshmallow.Orange);
            marshmallowsweet.TypeSweet();

                Console.WriteLine();
                Console.WriteLine("сортировка по сахару");
                foreach (var items in gift.FindCandyBySugar(70, 110))
                {
                    Console.WriteLine("{0}, Сахар: {1}", items.Name, items.Sugar);
                }



                Console.WriteLine();
                Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
                Console.ReadKey();
        
            
        }
    }
}

