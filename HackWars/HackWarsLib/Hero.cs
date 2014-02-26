using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;


namespace HackWarsLib
{
    abstract public class Hero
    {

        public string Name { get; private set; }

        private Item[] inventory;

        //public ImageSource Picture { get; private set; }

        public Hero(string name,params Item[] items )
        {
            this.Name = name;
            this.inventory = new Item[10];
            if (items.Count()>10) throw new ArgumentOutOfRangeException("To many items.");
            for (int i = 0; i < items.Count(); i++)
            {
                inventory[i] = items[i];
            }


        }
        public uint DefensePoints()
        {
            return 0;
        }

        public uint AttackPoints()
        {
            return 0;
        }
    }
}
