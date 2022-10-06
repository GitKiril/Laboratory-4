using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class HeroStats<T> where T : Hero
    {
        public void InDegub(T hero)
        {
            Console.WriteLine($"Your hero is : {hero} and his price : {hero.Price} and id is : {hero.Id} ");
            Console.WriteLine($"Your hero is : {hero} and his price : {hero.Price} and id is : {hero.Id} ");
        }
    }
}
