using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class Attack : Item
    {
        public int attack { get; set; }

        public Attack(int attack)
        {
            this.attack = attack;
        }

        public override void Buy()
        {
            attack += attackOfItem;
        }
        public override void Sell()
        {
            attack -= attackOfItem;
        }
    }
}
