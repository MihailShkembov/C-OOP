using System;
using System.Collections.Generic;
using System.Text;

namespace _0._3ShopingSpree
{
   public class Product
    {
        private string name;
        private double cost;

        public Product(string name,double cost)
        {
            this.Name = name;
            this.Cost = cost;

        }
        public string Name
        {
            get
            {
                return this.name;
            }
          private  set
            {
                if (String.IsNullOrEmpty(value))
                {
                    //Print Impossible cmd
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public double Cost
        {
            get
            {
                return this.cost;
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
                    this.cost = value;
                }
            }
        }
    }
}
