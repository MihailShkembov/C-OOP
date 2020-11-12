using _0._3Raiding.Core.Interfaces;
using _0._3Raiding.Factories;
using _0._3Raiding.Models;
using System;
using System.Collections.Generic;

namespace _0._3Raiding.Core
{
    public class Enginge : IEnginge
    {
        private Factory factory = new Factory();
        private List<BaseHero> list=new List<BaseHero>();
        public Enginge()
        {

        }
        public void Run()
        {

            int n = int.Parse(Console.ReadLine());
            int totalHeroesPower = 0;
            while (list.Count != n)
            {
                BaseHero currHero = null;
                try
                {
                    string name = Console.ReadLine();
                    string classType = Console.ReadLine();
                    currHero = factory.CreateHero(name, classType);
                    totalHeroesPower += currHero.Power;
                    list.Add(currHero);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.CastAblilty());
            }

            int enemyPower = int.Parse(Console.ReadLine());
            if (totalHeroesPower >= enemyPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
