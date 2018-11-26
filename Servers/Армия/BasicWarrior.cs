using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public abstract class BasicWarrior
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
        #region GETTERS
        public string GETtype()
        {
            return type;
        }
        public string GETname()
        {
            return name;
        }
        public double GETinvestigation()
        {
            return investigation;
        }
        public double GETattack()
        {
            return attack;
        }
        public double GETinfantry()
        {
            return infantry;
        }
        public double GETcavalry()
        {
            return cavalry;
        }
        public double GETmagistrate()
        {
            return magistrate;
        }
        public double GETbestiary()
        {
            return bestiary;
        }
        public double GETresources()
        {
            return resources;
        }
        public double GETmeat()
        {
            return meat;
        }
        public double GETtraverseSpeed()
        {
            return traverseSpeed;
        }
        public int GETtime()
        {
            return constructionTime;
        }

        #endregion

        #region SETTERS
        public void SETtype(string Type)
        {
            type = Type;
        }
        public void SETname(string Name)
        {
            name = Name;
        }
        public void SETinvestigation(double Investigation)
        {
            investigation = Investigation;
        }
        public void SETattack(double Attack)
        {
            attack = Attack;
        }
        public void SETinfantry(double Infantry)
        {
            infantry = Infantry;
        }
        public void SETcavalry(double Cavalry)
        {
            cavalry = Cavalry;
        }
        public void SETmagistrate(double Magistrate)
        {
            magistrate = Magistrate;
        }
        public void SETbestiary(double Bestiary)
        {
            bestiary = Bestiary;
        }
        public void SETresources(double Resources)
        {
            resources = Resources;
        }
        public void SETmeat(double Meat)
        {
            meat = Meat;
        }
        public void SETtraverseSpeed(double TraverseSpeed)
        {
            traverseSpeed = TraverseSpeed;
        }
        public void SETconstructionTime(int ConstructionTime)
        {
            constructionTime = ConstructionTime;
        }

        #endregion

        public string Type { get; set; }
        public string Name { get; set; }
        public double Investigation { get; set; }
        public double Attack {
            get { return attack; } // атака
            set
            {
                attack = value;
                ConstructionTime = attack > 0 ? ConstructionTime - TimeSpan.FromSeconds(1) : ConstructionTime + TimeSpan.FromSeconds(1);
            }
        }
        public double Infantry { get; set; }
        public double Cavalry { get; set; }
        public double Magistrate { get; set; }
        public double Bestiary { get; set; }
        public double Resources { get; set; }
        public double Meat { get; set; }
        public double TraverseSpeed { get; set; }

        public override string ToString()
        {
            string warrior = string.Format(this.GetType().Name + " :  \nТип - {0}"
                                                                   + "\nИмя- {1}"
                                                                   + "\nРазведка - {2}"
                                                                   + "\nАтака - {3}"
                                                                   + "\nЗащита от пехоты - {4}"
                                                                   + "\nЗащита от кавалерии - {5}"
                                                                   + "\nЗащита от магистрата - {6}"
                                                                   + "\nЗащита от бастерии - {7}"
                                                                   + "\nНесет ресурсов при грабеже - {8}"
                                                                   + "\nСтоимость содержания в час - {9}"
                                                                   + "\nСкорость движения - {10}"
                                                                   + "\nВремя строительства - {11}",
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
