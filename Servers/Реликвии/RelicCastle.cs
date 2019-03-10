using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Защищающие реликвии для замка
/// </summary>

namespace Servers
{
    class RelicCastle
    {
        private ConstructionTime constructionTime;

        public RelicCastle()
        {
        }
        public RelicCastle(ConstructionTime constructionTime)
        {
            this.constructionTime = constructionTime;
        }

        #region SteelmakerPincers
        public BasicRelicCastle.SteelmakerPincers[] CreateSteelmakerPincers(int count)
        {
            BasicRelicCastle.SteelmakerPincers[] steelmakerPincerss = new BasicRelicCastle.SteelmakerPincers[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.SteelmakerPincers steelmakerPincers = new BasicRelicCastle.SteelmakerPincers(new ConstructionTime() { Day = 3 });

                steelmakerPincers.NameRelic = "Клещи Сталевара";
                steelmakerPincers.RelicType = "Серийный";
                steelmakerPincers.UnitName = "Добыча ресурсов:";
                steelmakerPincers.PrSteel += 10;
                steelmakerPincers.Day = 3;
                steelmakerPincers.Lvl = 18;

                steelmakerPincerss[k] = steelmakerPincers;
            }
            return steelmakerPincerss;
        }

        #endregion

        #region BranFoundry
        public BasicRelicCastle.BranFoundry[] CreateBranFoundry(int count)
        {
            BasicRelicCastle.BranFoundry[] branFoundrys = new BasicRelicCastle.BranFoundry[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.BranFoundry branFoundry = new BasicRelicCastle.BranFoundry(new ConstructionTime() { Day = 7 });

                branFoundry.NameRelic = "Плавильня Брана";
                branFoundry.RelicType = "Элитный";
                branFoundry.PrSteel += 5;
                branFoundry.Day = 7;
                branFoundry.Lvl = 24;

                branFoundrys[k] = branFoundry;
            }
            return branFoundrys;
        }

        #endregion

        #region LeprekonaHat
        public BasicRelicCastle.LeprekonaHat[] CreateLeprekonaHat(int count)
        {
            BasicRelicCastle.LeprekonaHat[] leprekonaHats = new BasicRelicCastle.LeprekonaHat[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.LeprekonaHat leprekonaHat = new BasicRelicCastle.LeprekonaHat(new ConstructionTime() { Day = 7 });

                leprekonaHat.NameRelic = "Шляпа Лепрекона";
                leprekonaHat.RelicType = "Серийный";
                leprekonaHat.UnitName = "Добыча ресурсов";
                leprekonaHat.PrGold += 10;
                leprekonaHat.Day = 3;
                leprekonaHat.Lvl = 18;

                leprekonaHats[k] = leprekonaHat;
            }
            return leprekonaHats;
        }

        #endregion

        #region CirceStekhanov
        public BasicRelicCastle.CirceStekhanov[] CreateCirceStekhanov(int count)
        {
            BasicRelicCastle.CirceStekhanov[] circeStekhanovs = new BasicRelicCastle.CirceStekhanov[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.CirceStekhanov circeStekhanov = new BasicRelicCastle.CirceStekhanov(new ConstructionTime() { Day = 7 });

                circeStekhanov.NameRelic = "Кирка Стэханов";
                circeStekhanov.RelicType = "Элитный";
                circeStekhanov.UnitName = "Добыча ресурсов";
                circeStekhanov.PrGold += 5;
                circeStekhanov.Day = 7;
                circeStekhanov.Lvl = 24;

                circeStekhanovs[k] = circeStekhanov;
            }
            return circeStekhanovs;
        }

        #endregion

        #region ButcherAxe
        public BasicRelicCastle.ButcherAxe[] CreateButcherAxe(int count)
        {
            BasicRelicCastle.ButcherAxe[] butcherAxes = new BasicRelicCastle.ButcherAxe[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.ButcherAxe butcherAxe = new BasicRelicCastle.ButcherAxe(new ConstructionTime() { });

                butcherAxe.NameRelic = "Топор Мясника";
                butcherAxe.RelicType = "Элитный";
                butcherAxe.UnitName = "Потребление ресурсов";
                butcherAxe.PrMeat -= 5;
                butcherAxe.Lvl = 18;

                butcherAxes[k] = butcherAxe;
            }
            return butcherAxes;
        }

        #endregion

        #region LovaraSpices
        public BasicRelicCastle.LovaraSpices[] CreateLovaraSpices(int count)
        {
            BasicRelicCastle.LovaraSpices[] lovaraSpicess = new BasicRelicCastle.LovaraSpices[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.LovaraSpices lovaraSpices = new BasicRelicCastle.LovaraSpices(new ConstructionTime() { });

                lovaraSpices.NameRelic = "Пряности Ловара";
                lovaraSpices.RelicType = "Элитный";
                lovaraSpices.UnitName = "Потребление ресурсов:";
                lovaraSpices.PrMeat -= 9;
                lovaraSpices.Lvl = 20;

                lovaraSpicess[k] = lovaraSpices;
            }
            return lovaraSpicess;
        }

        #endregion

        #region SpiritSoy
        public BasicRelicCastle.SpiritSoy[] CreateSpiritSoy(int count)
        {
            BasicRelicCastle.SpiritSoy[] spiritSoys = new BasicRelicCastle.SpiritSoy[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.SpiritSoy spiritSoy = new BasicRelicCastle.SpiritSoy(new ConstructionTime() { });

                spiritSoy.NameRelic = "Дух Сои";
                spiritSoy.RelicType = "Элитный";
                spiritSoy.UnitName = "Потребление ресурсов";
                spiritSoy.PrMeat -= 12;
                spiritSoy.Lvl = 24;

                spiritSoys[k] = spiritSoy;
            }
            return spiritSoys;
        }

        #endregion

        #region LovarPot
        public BasicRelicCastle.LovarPot[] CreateLovarPot(int count)
        {
            BasicRelicCastle.LovarPot[] lovarPots = new BasicRelicCastle.LovarPot[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.LovarPot lovarPot = new BasicRelicCastle.LovarPot(new ConstructionTime() { });

                lovarPot.NameRelic = "Горшок Ловара";
                lovarPot.RelicType = "Элитный";
                lovarPot.UnitName = "Потребление ресурсов";
                lovarPot.PrMeat -= 15;
                lovarPot.Lvl = 28;

                lovarPots[k] = lovarPot;
            }
            return lovarPots;
        }

        #endregion

        #region MerlinAbstracts
        public BasicRelicCastle.MerlinAbstracts[] CreateMerlinAbstracts(int count)
        {
            BasicRelicCastle.MerlinAbstracts[] merlinAbstractss = new BasicRelicCastle.MerlinAbstracts[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.MerlinAbstracts merlinAbstracts = new BasicRelicCastle.MerlinAbstracts(new ConstructionTime() { });

                merlinAbstracts.NameRelic = "Конспекты Мерлина";
                merlinAbstracts.RelicType = "Особый";
                merlinAbstracts.UnitName = " ";
                merlinAbstracts.SpeedResearches += 10;
                merlinAbstracts.Day = 7;
                merlinAbstracts.Lvl = 20;

                merlinAbstractss[k] = merlinAbstracts;
            }
            return merlinAbstractss;
        }

        #endregion

        #region IronMaiden
        public BasicRelicCastle.IronMaiden[] CreateIronMaiden(int count)
        {
            BasicRelicCastle.IronMaiden[] ironMaidens = new BasicRelicCastle.IronMaiden[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.IronMaiden ironMaiden = new BasicRelicCastle.IronMaiden(new ConstructionTime() { Day = 14 });

                ironMaiden.NameRelic = "Железная Дева";
                ironMaiden.RelicType = "Элитный";
                ironMaiden.UnitName = " ";
                ironMaiden.SpeedResearches += 10;
                ironMaiden.Day = 14;
                ironMaiden.Lvl = 24;

                ironMaidens[k] = ironMaiden;
            }
            return ironMaidens;
        }

        #endregion

        #region ProtectionGods
        public BasicRelicCastle.ProtectionGods[] CreateProtectionGods(int count)
        {
            BasicRelicCastle.ProtectionGods[] protectionGodss = new BasicRelicCastle.ProtectionGods[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.ProtectionGods protectionGods = new BasicRelicCastle.ProtectionGods(new ConstructionTime() { Day = 7 });

                protectionGods.NameRelic = "Защита богов";
                protectionGods.RelicType = "Элитный";
                protectionGods.Sector = 2000;
                protectionGods.Day = 7;
                protectionGods.Lvl = 26;

                protectionGodss[k] = protectionGods;
            }
            return protectionGodss;
        }

        #endregion

        #region HeldNetwork
        public BasicRelicCastle.HeldNetwork[] CreateHeldNetwork(int count)
        {
            BasicRelicCastle.HeldNetwork[] heldNetworks = new BasicRelicCastle.HeldNetwork[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicCastle.HeldNetwork heldNetwork = new BasicRelicCastle.HeldNetwork(new ConstructionTime() { Day = 14 });

                heldNetwork.NameRelic = "Сеть Хельд";
                heldNetwork.RelicType = "Элитный";
                heldNetwork.UnitName = " ";
                heldNetwork.Sector = 3000;
                heldNetwork.Day = 14;
                heldNetwork.Lvl = 28;

                heldNetworks[k] = heldNetwork;
            }
            return heldNetworks;
        }
        
        #endregion

    }
}
