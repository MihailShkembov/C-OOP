

namespace _0._4BorderControl
{
   public class Cat:ICelebretable,INamable
    {
        public Cat(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
