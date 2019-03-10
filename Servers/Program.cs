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
            BasicInfantry.Kopeyshchik[] k;
            var fabrics = new WarriorFabric();
            k = fabrics.CreateKopeyshik(1);
            Console.WriteLine(k[0].ToString());

            Console.WriteLine("\n");

            BasicRelicOF.AngerDrop[] i;
            var fabric = new RelicOF();
            i = fabric.CreateAngerDrop(1);
            Console.WriteLine(i[0].ToString());

            Console.ReadKey();
        }

        
    }
} 
