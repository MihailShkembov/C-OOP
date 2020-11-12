
namespace _0._4BorderControl
{
   public class Person:IIdentifiable,ICelebretable,INamable
    {
        public Person(string name,int age, string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
