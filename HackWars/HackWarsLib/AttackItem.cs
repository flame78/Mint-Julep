using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class AttackItem : Item
    {
        public int attack { get; set; }

        public override void Buy()
        {
         //   attack += attackOfItem;
        }
        public override void Sell()
        {
         //   attack -= attackOfItem;
        }
    }
}
