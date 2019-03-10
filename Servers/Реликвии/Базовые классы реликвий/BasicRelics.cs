using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public class BasicRelics : ConstructionTime
    {
        //BasicRelics basicRelics = new BasicRelics("имя реликвии", "тип реликвии", "тип юнита", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0);
        private string nameRelic = " имя реликвии"; // имя реликвии
        private string relicType = "тип реликвии"; // тип реликвии
        private string unitName = "тип юнита"; // к какому типу юнита принадлежит реликвия
        private double attack = 0.0d; // Атака
        private double protection = 0.0d; // Защита:
        private double sector = 0.0d; // Защиты замка:
        private double movementSpeed = 0.0d; // Скорости передвижения:
        private double loadingCapacity = 0.0d; // Грузоподъемность:
        private double constructionUnits = 0.0d; // Постройки юнитов:
        private double speedConstructionUnits = 0.0d; // Скорости постройки юнитов:
        private double againstInvestigation = 0.0d; // Защиты от разведки:
        private double prSteel = 0.0d; // Сталь
        private double prGold = 0.0d; // Золото:
        private double prMeat = 0.0d; // Мясо:
        private double speedResearches = 0.0d; // Скорость исследований:
        private byte lvl = 0; // Необходимый уровень:
        private bool relicOn = true;

        #region Getters/Setters

        public string NameRelic { get { return nameRelic; } set { nameRelic = value; } }
        public string RelicType { get { return relicType; } set { relicType = value; } }
        public string UnitName { get { return unitName; } set { unitName = value; } }
        public double Attack { get { return attack; } set { attack = value; } }
        public double Protection { get { return protection; } set { protection = value; } }
        public double Sector { get { return sector; } set { sector = value; } }
        public double MovementSpeed { get { return movementSpeed; } set { movementSpeed = value; } }
        public double LoadingCapacity { get { return loadingCapacity; } set { loadingCapacity = value; } }
        public double ConstructionUnits { get { return constructionUnits; } set { constructionUnits = value; } }
        public double SpeedConstructionUnits { get { return speedConstructionUnits; } set { speedConstructionUnits = value; } }
        public double AgainstInvestigation { get { return againstInvestigation; } set { againstInvestigation = value; } }
        public double PrSteel { get { return prSteel; } set { prSteel = value; } }
        public double PrGold { get { return prGold; } set { prGold = value; } }
        public double PrMeat { get { return prMeat; } set { prMeat = value; } }
        public double SpeedResearches { get { return speedResearches; } set { speedResearches = value; } }
        public byte Lvl { get { return lvl; } set { lvl = value; } }

        /// <summary>
        /// RelicOn указывает на то, включен артефакт или выключен
        /// </summary>
        public virtual bool RelicOn { get; set; }

        #endregion


        public BasicRelics(ConstructionTime constructionTime)
        {
            ConstructionTime =
                  TimeSpan.FromDays(constructionTime.Day)
                + TimeSpan.FromHours(constructionTime.Hour)
                + TimeSpan.FromMinutes(constructionTime.Min)
                + TimeSpan.FromSeconds(constructionTime.Sec);
        }

        public TimeSpan ConstructionTime { get; private set; }


        public override string ToString()
        {
            string relic = string.Format(this.GetType().Name + " :  \nИмя реликвии: {0}"
                                                                 + "\nТип реликвии: {1}"
                                                                 + "\nТип юнита: {2}"
                                                                 + "\nАтака: {3}"
                                                                   , this.nameRelic,
                                                                     this.relicType,
                                                                     this.unitName,
                                                                     this.attack
                                                                                );
            return relic;
        }
               
    }
}
