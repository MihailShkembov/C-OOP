using _0._3Raiding.Common;
using _0._3Raiding.Models;
using System;


namespace _0._3Raiding.Factories
{
   public class Factory
    {
        public BaseHero CreateHero(string name,string classType)
        {
            BaseHero hero;
            if (classType=="Druid")
            {
                hero = new Druid(name);
            }
            else if (classType == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (classType == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (classType == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new InvalidOperationException(Messages.InvalidHeroExceptionMessage);
            }
            return hero;

        }
    }
}
