﻿using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loba loba = new Loba(3, 12000);
            Mirage mirage = new Mirage(4, 12000);
            HeroStats<Hero> hero = new HeroStats<Hero>();
            hero.InDegub(loba);
            hero.InDegub(mirage);
        }
    }   
}
