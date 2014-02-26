using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class Defense : Item
    {
        public int defense { get; set; }

        public override void Buy()
        {
            defense += defenseOfItem;
        }
        public override void Sell()
        {
            defense -= defenseOfItem;
        }
    }
}
