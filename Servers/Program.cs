using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class Program
    {

        static void Main(string[] args)
        {
            BasicMagistrate.DarkNecromancer[] k;
            var fabric = new WarriorFabric();

            k = fabric.CreateDarkNecromancer(1);
            Console.WriteLine(k[0].ToString());
            Console.ReadKey();
        }
    }
}
