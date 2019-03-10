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
            BasicInfantry.Patriarch[] k;
            var fabric = new WarriorFabric();

            k = fabric.CreatePatriarch(1);
            Console.WriteLine(k[0].ToString());
            Console.ReadKey();
        }
    }
}
