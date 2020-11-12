using System;
using System.Collections.Generic;
using System.Text;

namespace _0._3ShopingSpree
{
    public  class Person
    {
        private string name;
        private double momey;
        public Person(string name,double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
        }
        public List<string> Products { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
          private  set
            {
                if (String.IsNullOrEmpty(value)||String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(-1);
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public double Money
        {
            get
            {
                return this.momey;
            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(-1);
                }
                else
                {
                    this.momey = value;
                }
            }
        }
    }
}
