using _0._3Raiding.Common;
using System;
namespace _0._3Raiding.Models
{
   public class Rogue:BaseHero
    {
        public Rogue(string name)
            :base(name)
        {

        }
        public override string Ability => String.Format(Messages.AttackersMessage, this.GetType().Name, this.Name, this.Power);
        public override int Power => 80;
    }
}
