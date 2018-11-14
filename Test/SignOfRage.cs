using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Класс Реликвии Знак Ярости
/// </summary>

namespace Test

{
    class SignOfRage
    {
        public string type; // Тип релика
        public string relicName; // Имя реликвии 
        public string nameArmy; // Имя армии
        public double attack = 60.0;
        public DateTime validTime;
        public int lvl;
        public bool signofrage;

        public static void ONOF()
        {
            Console.Write("Активировать Знак Ярости? да/нет ");
            SignOfRage sign = new SignOfRage();
            var input = Console.ReadLine().ToLower();
            sign.signofrage = false;
            if (input.Equals("да"))
            {
                sign.signofrage = true;

                Console.Write("Реликвия Знак Ярости активен\n \n");
                SignOfRage.On();
                Console.ReadKey();
            }
            if (input.Equals("нет"))
            {
                sign.signofrage = false;

                Console.Write("Реликвия Знак Ярости не активен\n \n");
                SignOfRage.Of();
                Console.ReadKey();
            }
        }

        public static void On()
        {
            string type = "0"; // Тип релика
            string relicName = " Знак Ярости"; // Имя реликвии 
            string nameArmy = "Копейщик"; // Имя армии
            double attack = 60.0d;
            DateTime validTime;
            int lvl = 0;
            bool signofrage;
            Console.WriteLine(Onn(ref type, ref relicName, ref nameArmy,ref  attack, ref lvl));
            Console.ReadKey();
        }

        public static void Of()
        {
            string type = "0"; // Тип релика
            string relicName = " Знак Ярости"; // Имя реликвии 
            string nameArmy = "Копейщик"; // Имя армии
            double attack = 60.0d;
            DateTime validTime;
            int lvl = 0;
            bool signofrage;
            Console.WriteLine(Off(type, relicName, nameArmy,  attack, ref lvl));
            Console.ReadKey();
        }

        public static string Off(string type, string relicName, string nameArmy,  double attack, ref int lvl)
        {
            type = "Серийный";
            relicName = "Знак Ярости";
            nameArmy = "Копейщик";
            attack = 60;
            lvl = 1;



            return "Тип: " + type + "\n" + "Название реликвии: " + relicName + "\n" + "Тип армии: " + nameArmy + "\n" + "Процент % к атаке: " + attack + "\n" + "Уровень реликвии: " + lvl;
        }

        public static string Onn(ref string type, ref string relicName, ref string nameArmy, ref double attack, ref int lvl)
        {
            type = "Серийный";
            relicName = "Знак Ярости";
            nameArmy = "Копейщик";
            attack = (attack*(2.5/100)) + attack;
            lvl = 1;



            return "Тип: " + type + "\n" + "Название реликвии: " + relicName + "\n" + "Тип армии: " + nameArmy + "\n" + "Процент % к атаке: " + attack + "\n" + "Уровень реликвии: " + lvl + "\n" + "\n";
        }
    }
}

