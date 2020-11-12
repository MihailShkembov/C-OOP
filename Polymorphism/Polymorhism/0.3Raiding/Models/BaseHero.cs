using _0._3Raiding.Models.Interfaces;
namespace _0._3Raiding.Models
{
    public class BaseHero : IHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; }

        public virtual int Power { get; }
        public virtual string Ability { get; }

        public  string CastAblilty()
        {
            return Ability;
        }
    }
}
