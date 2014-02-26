using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    abstract public class Item
    {
      public string Name { get; private set; }
        public double Price { get; private set; }
      
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        
        }

        public Item()
        {
        }

        public Item(int itemCount)
        {
            this.itemList = new Item[itemCount];
        }

        public virtual void Buy()
        {
        }

        public virtual void Sell()
        {
        }

    }
}
