using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class Impirium
    {
        string imperium;
        string townHall="Ратуша"; // ратуша

        public Impirium(string townHall)
        {
            this.townHall = townHall;
        }

        public string TownHall
        {
            set { townHall = townHall; }
            get { return townHall; }
        }
    }
}   


