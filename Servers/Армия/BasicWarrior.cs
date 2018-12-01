using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public abstract class BasicWarrior : Resources
    {
        private string type; // пехота/кавалерия/магистрат/бастеария
        private string name; // имя юнита
        private double investigation; // разведка
        private double attack; // атака
        private double infantry; // защита от пехоты
        private double cavalry;  // защита от кавалерии
        private double magistrate; // защита от магистрата
        private double bestiary;  // защита от бестиарии
        private double resources; // несет ресурсов при грабеже
        private double meat;  // стоимость содержания в час
        private double traverseSpeed;  // скорость перемещения
        private int constructionTime;  // время строительства
       
        /// <summary>
        /// true - указывает на то,что воин является атакующим
        /// false - указывает на то,что воин является защитником
        /// </summary>
        public virtual bool off { get; set; }

        public BasicWarrior(ConstructionTime constructionTime)
        {
            ConstructionTime =
                               TimeSpan.FromDays(constructionTime.Day)
                               + TimeSpan.FromHours(constructionTime.Hour)
                               + TimeSpan.FromMinutes(constructionTime.Min)
                               + TimeSpan.FromSeconds(constructionTime.Sec);
        }

        public TimeSpan ConstructionTime { get; private set; }
        

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; }set { name = value; } }
        public double Investigation { get { return investigation; } set { investigation = value; } }
        public double Attack
        {
            get { return attack; } // атака
            set
            {
                attack = value;
                ConstructionTime = attack > 0 ? ConstructionTime - TimeSpan.FromSeconds(1) : ConstructionTime + TimeSpan.FromSeconds(1);
            }
        }
        public double Infantry { get { return infantry; } set { infantry = value; } }
        public double Cavalry { get { return cavalry; } set { cavalry = value; } }
        public double Magistrate { get { return magistrate; } set { magistrate = value; } }
        public double Bestiary { get { return bestiary; } set { bestiary = value; } }
        public double Resources { get { return resources; } set { resources = value; } }
        public double Meat { get { return meat; } set { meat = value; } }
        public double TraverseSpeed { get { return traverseSpeed; } set { traverseSpeed = value; } }
        //public int ConstructionTime { get { return constructionTime; } set { constructionTime = value; } }

        public override string ToString()
        {
            string warrior = string.Format(this.GetType().Name + " :  \nТип: {0}"
                                                                   + "\nИмя: {1}"
                                                                   + "\nРазведка: {2}"
                                                                   + "\nАтака: {3}"
                                                                   + "\nЗащита от пехоты: {4}"
                                                                   + "\nЗащита от кавалерии: {5}"
                                                                   + "\nЗащита от магистрата: {6}"
                                                                   + "\nЗащита от бастерии: {7}"
                                                                   + "\nНесет ресурсов при грабеже: {8}"
                                                                   + "\nСтоимость содержания в час: {9}"
                                                                   + "\nСкорость движения: {10}"
                                                                   + "\nВремя строительства: {11}",
                                                                                                 type,
                                                                                                 name,
                                                                                                 investigation,
                                                                                                 attack,
                                                                                                 infantry,
                                                                                                 cavalry,
                                                                                                 magistrate,
                                                                                                 bestiary,
                                                                                                 resources,
                                                                                                 meat,
                                                                                                 traverseSpeed,
                                                                                                 ConstructionTime);
            return warrior;
        }

        
    }
}
