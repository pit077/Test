using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Класс Реликвии Капли Гнева
/// </summary>


namespace Test
{
    class AngerDrops
    {
        public string type; // Тип релика
        public string relicName; // Имя реликвии 
        public string nameArmy; // Имя армии
        public double attack = 60.0;
        public DateTime validTime;
        public int lvl;
        public bool angerdrop;


        public static void ONOF()
        {
            Console.Write("Активировать Капли Гнева? да/нет ");
            AngerDrops anger = new AngerDrops();
            SignOfRage sign = new SignOfRage();
            double c;

            var input = Console.ReadLine().ToLower();
            anger.angerdrop = false;
            if (input.Equals("да"))
            {
                anger.angerdrop = true;

                Console.Write("Реликвия Капли Гнева активна\n \n");
                AngerDrops.On();
                Console.ReadKey();
            }
            
            if (input.Equals("нет"))
            {
                anger.angerdrop = false;

                Console.Write("Реликвия Капли Гнева не активна\n \n");
                AngerDrops.Of();
                Console.ReadKey();
            }
        }
        public static void On()
        {
            string type = "0"; // Тип релика
            string relicName = " Капли гнева"; // Имя реликвии 
            string nameArmy = "Копейщик"; // Имя армии
            double attack = 60.0d;
            DateTime validTime;
            int lvl = 0;
            bool angerdrop;
            Console.WriteLine(Onn(ref type, ref relicName, ref nameArmy, attack, ref lvl));
            Console.ReadKey();
        }
        public static void Of()
        {
            string type = "0"; // Тип релика
            string relicName = " Капли гнева"; // Имя реликвии 
            string nameArmy = "Копейщик"; // Имя армии
            double attack = 60.0d;
            DateTime validTime;
            int lvl = 0;
            bool angerdrop;
            Console.WriteLine(Off(type, relicName, nameArmy, attack, ref lvl));
            Console.ReadKey();
        }
        public static string Off(string type, string relicName, string nameArmy, double attack, ref int lvl)
        {
            type = "Серийный";
            relicName = "Капли гнева";
            nameArmy = "Копейщик";
            attack = 60;
            lvl = 24;



            return "Тип: " + type + "\n" + "Название реликвии: " + relicName + "\n" + "Тип армии: " + nameArmy + "\n" + "Процент % к атаке: " + attack + "\n" + "Уровень реликвии: " + lvl;
        }
        public static string Onn(ref string type, ref string relicName, ref string nameArmy, double attack, ref int lvl)
        {
            type = "Серийный";
            relicName = "Капли гнева";
            nameArmy = "Копейщик";
            attack = ((4.0 / 100) * attack) + attack;
            lvl = 24;



            return "Тип: " + type + "\n" + "Название реликвии: " + relicName + "\n" + "Тип армии: " + nameArmy + "\n" + "Процент % к атаке: " + attack + "\n" + "Уровень реликвии: " + lvl + "\n" + "\n";
        }
    }

}
