using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _0._4BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            var list = new List<ICelebretable>();
            while (!cmd.Contains("End"))
            {
                if (cmd.Count == 3)
                {
                    string name = cmd[1];  
                    string birthdate = cmd[2];
                    ICelebretable tempCat = new Cat(name, birthdate);
                    list.Add(tempCat);
                }
                else if (cmd.Count==5)
                {
                    string name = cmd[1];
                    int age = int.Parse(cmd[2]);
                    string id = cmd[3];
                    string birthdate = cmd[4];
                    ICelebretable tempPerson = new Person(name, age, id, birthdate);
                    list.Add(tempPerson);
                }
                else
                {
                    string model = cmd[1];
                    string id = cmd[2];
                    var tempRobot = new Robot(model, id);
                  
                }
                cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            }
            string year = Console.ReadLine();
            var peopleBornInTheYear = new List<string>();
            foreach (var item in list)
            {
                if (item.Birthdate.Contains(year))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}

