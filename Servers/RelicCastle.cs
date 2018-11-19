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
    class RelicCastle:BasicRelics
    {
        public void SteelmakerPincers()
        {
            RelicCastle steelmakerPincers = new RelicCastle();
            steelmakerPincers.NameRelic = "Клещи Сталевара";
            steelmakerPincers.RelicType = "Серийный";
            steelmakerPincers.UnitName = "Добыча ресурсов:";
            steelmakerPincers.PrSteel += 10;
            steelmakerPincers.Day = 3;
            steelmakerPincers.Lvl = 18;
        }
        public void BranFoundry()
        {
            RelicCastle branFoundry = new RelicCastle();
            branFoundry.NameRelic = "Плавильня Брана";
            branFoundry.RelicType = "Элитный";
            branFoundry.PrSteel += 5;
            branFoundry.Day = 7;
            branFoundry.Lvl = 24;
        }
        public void LeprekonaHat()
        {
            RelicCastle leprekonaHat = new RelicCastle();
            leprekonaHat.NameRelic = "Шляпа Лепрекона";
            leprekonaHat.RelicType = "Серийный";
            leprekonaHat.UnitName = "Добыча ресурсов";
            leprekonaHat.PrGold += 10;
            leprekonaHat.Day = 3;
            leprekonaHat.Lvl = 18;
        }
        public void CirceStekhanov()
        {
            RelicCastle circeStekhanov = new RelicCastle();
            circeStekhanov.NameRelic = "Кирка Стэханов";
            circeStekhanov.RelicType = "Элитный";
            circeStekhanov.UnitName = "Добыча ресурсов";
            circeStekhanov.PrGold += 5;
            circeStekhanov.Day = 7;
            circeStekhanov.Lvl = 24;
        }
        public void ButcherAxe()
        {
            RelicCastle butcherAxe = new RelicCastle();
            butcherAxe.NameRelic = "Топор Мясника";
            butcherAxe.RelicType = "Элитный";
            butcherAxe.UnitName = "Потребление ресурсов";
            butcherAxe.PrMeat -= 5;
            butcherAxe.Lvl = 18;
        }
        public void LovaraSpices()
        {
            RelicCastle lovaraSpices = new RelicCastle();
            lovaraSpices.NameRelic = "Пряности Ловара";
            lovaraSpices.RelicType = "Элитный";
            lovaraSpices.UnitName = "Потребление ресурсов:";
            lovaraSpices.PrMeat -= 9;
            lovaraSpices.Lvl = 20;
        }
        public void SpiritSoy()
        {
            RelicCastle spiritSoy = new RelicCastle();
            spiritSoy.NameRelic = "Дух Сои";
            spiritSoy.RelicType = "Элитный";
            spiritSoy.UnitName = "Потребление ресурсов";
            spiritSoy.PrMeat -= 12;
            spiritSoy.Lvl = 24;
        }
        public void LovarPot()
        {
            RelicCastle lovarPot = new RelicCastle();
            lovarPot.NameRelic = "Горшок Ловара";
            lovarPot.RelicType = "Элитный";
            lovarPot.UnitName = "Потребление ресурсов";
            lovarPot.PrMeat -= 15;
            lovarPot.Lvl = 28;
        }
        public void MerlinAbstracts()
        {
            RelicCastle merlinAbstracts = new RelicCastle();
            merlinAbstracts.NameRelic = "Конспекты Мерлина";
            merlinAbstracts.RelicType = "Особый";
            merlinAbstracts.UnitName = " ";
            merlinAbstracts.SpeedResearches += 10;
            merlinAbstracts.Day = 7;
            merlinAbstracts.Lvl = 20;
        }
        public void IronMaiden()
        {
            RelicCastle ironMaiden = new RelicCastle();
            ironMaiden.NameRelic = "Железная Дева";
            ironMaiden.RelicType = "Элитный";
            ironMaiden.UnitName = " ";
            ironMaiden.SpeedResearches += 10;
            ironMaiden.Day = 14;
            ironMaiden.Lvl = 24;
        }
        public void ProtectionGods()
        {
            RelicCastle protectionGods = new RelicCastle();
            protectionGods.NameRelic = "Защита богов";
            protectionGods.RelicType = "Элитный";
            protectionGods.Sector = 2000;
            protectionGods.Day = 7;
            protectionGods.Lvl = 26;
        }
        public void HeldNetwork()
        {
            RelicCastle heldNetwork = new RelicCastle();
            heldNetwork.NameRelic = "Сеть Хельд";
            heldNetwork.RelicType = "Элитный";
            heldNetwork.UnitName = " ";
            heldNetwork.Sector = 3000;
            heldNetwork.Day = 14;
            heldNetwork.Lvl = 28;
        }
    }
}
