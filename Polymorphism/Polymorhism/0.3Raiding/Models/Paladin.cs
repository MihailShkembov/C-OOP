﻿using _0._3Raiding.Common;
using System;

namespace _0._3Raiding.Models
{
  public  class Paladin:BaseHero
    {
        public Paladin(string name)
            :base(name)
        {

        }
        public override string Ability => String.Format(Messages.HealersMessage, this.GetType().Name, this.Name, this.Power);
        public override int Power => 100;
    }
}
