using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public int defenseOfItem { get; set; }
        public int attackOfItem { get; set; }

        public Item(string name, double price, int defenseOfItem, int attackOfItem)
        {
            this.name = name;
            this.price = price;
            this.defenseOfItem = defenseOfItem;
            this.attackOfItem = attackOfItem;
        }

        public virtual void Buy()
        {
        }

        public virtual void Sell()
        {
        }

    }
}
