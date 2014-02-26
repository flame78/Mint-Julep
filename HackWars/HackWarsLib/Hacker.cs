using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class Hacker : Hero
    {
        private double money;

        public Hacker(string name) : base(name)
        {
            this.money = 100;
        }
    }
}
