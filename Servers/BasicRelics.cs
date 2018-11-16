using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    class BasicRelics : ConstructionTime
    {
        //BasicRelics basicRelics = new BasicRelics("имя реликвии", "тип реликвии", "тип юнита", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0);
        private string nameRelic = " имя реликвии"; // имя реликвии
        private string relicType = "тип реликвии"; // тип реликвии
        private string unitName = "тип юнита"; // к какому типу юнита принадлежит реликвия
        private double attack = 0.0d; // процент атаки
        private double protection = 0.0d; // процент защиты
        private double sector = 0.0d; // процент защиты замка
        private double movementSpeed = 0.0d; // процент скорости передвижения
        private double loadingCapacity = 0.0d; // процент грузоподъемности
        private double constructionUnits = 0.0d; // процент постройки юнитов
        private double costConstructionUnits = 0.0d; // процент стоимости постройки юнитов
        private double speedConstructionUnits = 0.0d; // процент скорости постройки юнитов
        private double againstInvestigation = 0.0d; // процент защиты от разведки
        private double prSteel = 0.0d; // процент к стали
        private double prGold = 0.0d; // процент к золоту
        private double prMeat = 0.0d; // процент к мясу
        private double speedResearches = 0.0d; // скорость исследований
        private byte lvl = 0; // необходимый уровень


        public BasicRelics(string nameRrelic, string relicType, string unitName, double attack, double protection,
            double sector, double movementSpeed, double loadingCapacity, double constructionUnits,
            double costConstructionUnits, double speedConstructionUnits, double againstInvestigation, double prSteel,
            double prGold, double prMeat, double speedResearches, byte lvl):this()
        {
            this.nameRelic = nameRrelic;
            this.relicType = relicType;
            this.unitName = unitName;
            this.attack = attack;
            this.protection = protection;
            this.sector = sector;
            this.movementSpeed = movementSpeed;
            this.loadingCapacity = loadingCapacity;
            this.constructionUnits = constructionUnits;
            this.costConstructionUnits = costConstructionUnits;
            this.speedConstructionUnits = speedConstructionUnits;
            this.againstInvestigation = againstInvestigation;
            this.prSteel = prSteel;
            this.prGold = prGold;
            this.prMeat = prMeat;
            this.speedResearches = speedResearches;
            this.lvl = lvl;

        }

        public BasicRelics()
        {
            nameRelic = " ";
            relicType = " ";
            unitName = " ";
            attack = 0;
            protection = 0;
            sector = 0;
            movementSpeed = 0;
            loadingCapacity = 0;
            constructionUnits = 0;
            costConstructionUnits = 0;
            speedConstructionUnits = 0;
            againstInvestigation = 0;
            prSteel = 0;
            prGold = 0;
            prMeat = 0;
            speedResearches = 0;
            lvl = 0;
        }

        public void BasicRelicsM()
        {
            string nameRelic; // имя реликвии
            string relicType = "тип реликвии"; // тип реликвии
            string unitName = "тип юнита"; // к какому типу юнита принадлежит реликвия
            double attack = 0.0d; // процент атаки
            double protection = 0.0d; // процент защиты
            double sector = 0.0d; // процент защиты замка
            double movementSpeed = 0.0d; // процент скорости передвижения
            double loadingCapacity = 0.0d; // процент грузоподъемности
            double constructionUnits = 0.0d; // процент постройки юнитов
            double costConstructionUnits = 0.0d; // процент стоимости постройки юнитов
            double speedConstructionUnits = 0.0d; // процент скорости постройки юнитов
            double againstInvestigation = 0.0d; // процент защиты от разведки
            double prSteel = 0.0d; // процент к стали
            double prGold = 0.0d; // процент к золоту
            double prMeat = 0.0d; // процент к мясу
            double speedResearches = 0.0d; // скорость исследований
            byte lvl = 0; // необходимый уровень
        }

        public string NameRelic { get; set; }
        public string RelicType { get; set; }
        public string UnitName { get; set; }
        public double Attack { get; set; }
        public double Protection { get; set; }
        public double Sector { get; set; }
        public double MovementSpeed { get; set; }
        public double LoadingCapacity { get; set; }
        public double ConstructionUnits { get; set; }
        public double CostConstructionUnits { get; set; }
        public double SpeedConstructionUnits { get; set; }
        public double AgainstInvestigation { get; set; }
        public double PrSteel { get; set; }
        public double PrGold { get; set; }
        public double PrMeat { get; set; }
        public double SpeedResearches { get; set; }
        public byte Lvl { get; set; }
    }
}
