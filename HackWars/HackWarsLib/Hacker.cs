using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackWarsLib
{
    public class Hacker : Hero
    {
        private static Hacker instance;

         public static Hacker Instance
         {
                get
                {
                    if (instance == null)
                    {
                        instance = new Hacker();
                    }
                        return instance;
                }
          }

        private double money;

        public Hacker() : base("unknow") { }
        public Hacker(string name) : base(name)
        {
            this.money = 100;
        }
    }
}
