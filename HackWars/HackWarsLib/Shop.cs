using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWarsLib
{
    class Shop
    {
        Item items = new Item(5);
        Item item1 = new Item("New Computer", 1000, 200, 500);
        Item item2 = new Item("Course for security", 2500, 300, 300);
        Item item3 = new Item("Sertificate", 5600, 400, 600);
        Item item4 = new Item("Books", 700, 400, 1000);
        Item item5 = new Item("zero-day exploits", 7000, 600, 900);
    }
}
