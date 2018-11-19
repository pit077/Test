using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Защищающие реликвии
/// </summary>

namespace Servers
{
    class RelicDEF:BasicRelics
    {
        public void ShlemBrana()
        {
            RelicDEF shlemBrana = new RelicDEF();
            shlemBrana.NameRelic = "Шлем Брана";
            shlemBrana.RelicType = "Элитный";
            shlemBrana.UnitName = "Всадник";
            shlemBrana.Protection += 8;
            shlemBrana.Lvl = 30;
        }
        public void CarePendant()
        {
            RelicDEF carePendant = new RelicDEF();
            carePendant.NameRelic = "Подвеска осторожности";
            carePendant.RelicType = "Серийный";
            carePendant.Protection += 6;
            carePendant.Day = 14;
            carePendant.Lvl = 18;
        }
        public void HonorShoulderStrap()
        {
            RelicDEF honorShoulderStrap = new RelicDEF();
            honorShoulderStrap.NameRelic = "Наплечник чести";
            honorShoulderStrap.RelicType = "Особый";
            honorShoulderStrap.UnitName = "Копейщик";
            honorShoulderStrap.Protection += 7.5;
            honorShoulderStrap.Lvl = 20;
        }
        public void ShodBoot()
        {
            RelicDEF shodBoot = new RelicDEF();
            shodBoot.NameRelic = "Кованый сапог";
            shodBoot.RelicType = "Особый";
            shodBoot.UnitName = "Копейщик";
            shodBoot.Protection += 12;
            shodBoot.MovementSpeed -= 25;
            shodBoot.Day = 7;
            shodBoot.Lvl = 22;
        }
        public void EyeWyvern()
        {
            RelicDEF eyeWyvern = new RelicDEF();
            eyeWyvern.NameRelic = "Глаз виверны";
            eyeWyvern.RelicType = "Особый";
            eyeWyvern.UnitName = "Копейщик";
            eyeWyvern.Protection += 12;
            eyeWyvern.ConstructionUnits += 5;
            eyeWyvern.Day = 14;
            eyeWyvern.Lvl = 26;
        }
        public void Thistle()
        {
            RelicDEF thistle = new RelicDEF();
            thistle.NameRelic = "Чертополох";
            thistle.RelicType = "Особый";
            thistle.UnitName = "Копейщик";
            thistle.Protection += 7.5;
            thistle.Lvl = 30;
        }
        public void RunicGuard()
        {
            RelicDEF runicGuard = new RelicDEF();
            runicGuard.NameRelic = "Рунический страж";
            runicGuard.RelicType = "Серийный";
            runicGuard.UnitName = "Лучница";
            runicGuard.Protection += 12;
            runicGuard.Day = 14;
            runicGuard.Lvl = 16;
        }
        public void ElfinChainArmor()
        {
            RelicDEF elfinChainArmor = new RelicDEF();
            elfinChainArmor.NameRelic = "Эльфийская кольчуга";
            elfinChainArmor.RelicType = "Серийный";
            elfinChainArmor.UnitName = "Лучница";
            elfinChainArmor.Protection += 5;
            elfinChainArmor.Lvl = 18;
        }
        public void SignSniper()
        {
            RelicDEF signSniper = new RelicDEF();
            signSniper.NameRelic = "Знак снайпера";
            signSniper.RelicType = "Серийный";
            signSniper.UnitName = "Лучница";
            signSniper.Protection += 12;
            signSniper.MovementSpeed -= 25;
            signSniper.Day = 14;
            signSniper.Lvl = 20;
        }
        public void MifrilovyNaruch()
        {
            RelicDEF mifrilovyNaruch = new RelicDEF();
            mifrilovyNaruch.NameRelic = "Мифриловые наручи";
            mifrilovyNaruch.NameRelic = "Особый";
            mifrilovyNaruch.UnitName = "Лучница";
            mifrilovyNaruch.Protection += 7.5;
            mifrilovyNaruch.Attack -= 10;
            mifrilovyNaruch.Lvl = 24;
        }
        public void SteelBeard()
        {
            RelicDEF steelBeard = new RelicDEF();
            steelBeard.NameRelic = "Стальная борода";
            steelBeard.RelicType = "Серийный";
            steelBeard.UnitName = "Гном";
            steelBeard.Protection += 7.5;
            steelBeard.Day = 14;
            steelBeard.Lvl = 24;
        }
        public void KonungBoard()
        {
            RelicDEF konungBoard = new RelicDEF();
            konungBoard.NameRelic = "Щит конунга";
            konungBoard.RelicType = "Особый";
            konungBoard.UnitName = "Гном";
            konungBoard.Protection += 5;
            konungBoard.Lvl = 26;
        }
        public void MarchingBrewery()
        {
            RelicDEF marchingBrewery = new RelicDEF();
            marchingBrewery.NameRelic = "Походная пивоварня";
            marchingBrewery.RelicType = "Особый";
            marchingBrewery.UnitName = "Гном";
            marchingBrewery.SpeedConstructionUnits += 5;
            marchingBrewery.Protection += 12;
            marchingBrewery.Day = 7;
            marchingBrewery.Lvl = 28;
        }
        public void BalinHorn()
        {
            RelicDEF balinHorn = new RelicDEF();
            balinHorn.NameRelic = "Рог Балина";
            balinHorn.RelicType = "Особый";
            balinHorn.UnitName = "Гном";
            balinHorn.Protection += 7.5;
            balinHorn.Attack -= 7.5;
            balinHorn.Lvl = 30;
        }
        public void OberonSpurs()
        {
            RelicDEF oberonSpurs = new RelicDEF();
            oberonSpurs.NameRelic = "Шпоры Оберона";
            oberonSpurs.RelicType = "Элитный";
            oberonSpurs.UnitName = "Кочевница";
            oberonSpurs.Protection += 12;
            oberonSpurs.Day = 7;
            oberonSpurs.Lvl = 32;
        }
        public void CavalryBoard()
        {
            RelicDEF cavalryBoard = new RelicDEF();
            cavalryBoard.NameRelic = "Кавалерийский щит";
            cavalryBoard.RelicType = "Элитный";
            cavalryBoard.UnitName = "Кочевница";
            cavalryBoard.Protection += 12;
            cavalryBoard.MovementSpeed -= 25;
            cavalryBoard.Day = 14;
            cavalryBoard.Lvl = 34;
        }
        public void DanaCharm()
        {
            RelicDEF danaCharm = new RelicDEF();
            danaCharm.NameRelic = "Оберег Даны";
            danaCharm.RelicType = "Особый";
            danaCharm.UnitName = "Кочевница";
            danaCharm.Protection += 10;
            danaCharm.Day = 14;
            danaCharm.Lvl = 32;
        }
        public void SkinBear()
        {
            RelicDEF skinBear = new RelicDEF();
            skinBear.NameRelic = "Шкура медвежутя";
            skinBear.RelicType = "Особый";
            skinBear.UnitName = "Кочевница";
            skinBear.Protection += 12;
            skinBear.MovementSpeed -= 25;
            skinBear.Day = 7;
            skinBear.Lvl = 34;
        }
        public void KhanArmor()
        {
            RelicDEF khanArmor = new RelicDEF();
            khanArmor.NameRelic = "Броня Хана";
            khanArmor.RelicType = "Элитный";
            khanArmor.UnitName = "Кочевница";
            khanArmor.Protection += 7.5;
            khanArmor.LoadingCapacity -= 30;
            khanArmor.Lvl = 36;
        }
        public void RahnBone()
        {
            RelicDEF rahnBone = new RelicDEF();
            rahnBone.NameRelic = "Кость Рана";
            rahnBone.RelicType = "Элитный";
            rahnBone.UnitName = "Варвар";
            rahnBone.Protection += 12;
            rahnBone.Day = 7;
            rahnBone.Lvl = 36;
        }
        public void AskarTrace()
        {
            RelicDEF askarTrace = new RelicDEF();
            askarTrace.NameRelic = "След Аскара";
            askarTrace.RelicType = "Элитный";
            askarTrace.UnitName = "Варвар";
            askarTrace.Protection += 7.5;
            askarTrace.Attack -= 7.5;
            askarTrace.Lvl = 37;
        }
        public void PressMary()
        {
            RelicDEF pressMary = new RelicDEF();
            pressMary.NameRelic = "Печать Мары";
            pressMary.RelicType = "Элитный";
            pressMary.UnitName = "Голем";
            pressMary.Protection += 7.5;
            pressMary.Day = 14;
            pressMary.Lvl = 38;
        }
        public void LordRing()
        {
            RelicDEF lordRing = new RelicDEF();
            lordRing.NameRelic = "Кольцо Владыки";
            lordRing.RelicType = "Элитный";
            lordRing.UnitName = "Голем";
            lordRing.Protection += 5;
            lordRing.Attack -= 5;
            lordRing.Lvl = 39;
        }
        public void SpiritFire()
        {
            RelicDEF spiritFire = new RelicDEF();
            spiritFire.NameRelic = "Дух Огня";
            spiritFire.RelicType = "Элитный";
            spiritFire.UnitName = "Голем";
            spiritFire.Protection += 5;
            spiritFire.Lvl = 42;
        }
        public void MuskMezlikikh()
        {
            RelicDEF muskMezlikikh = new RelicDEF();
            muskMezlikikh.NameRelic = "Маска Безликих";
            muskMezlikikh.RelicType = "Особый";
            muskMezlikikh.AgainstInvestigation += 8;
            muskMezlikikh.Day = 14;
            muskMezlikikh.Lvl = 18;
        }
        public void ChaosEye()
        {
            RelicDEF chaosEye = new RelicDEF();
            chaosEye.NameRelic = "Око Хаоса";
            chaosEye.RelicType = "Элитный";
            chaosEye.UnitName = "Шпион";
            chaosEye.Protection += 4;
            chaosEye.Lvl = 20;
        }
        public void SteelFeather()
        {
            RelicDEF steelFeather = new RelicDEF();
            steelFeather.NameRelic = "Стальное перо";
            steelFeather.RelicType = "Элитный";
            steelFeather.UnitName = "Грифон";
            steelFeather.Protection += 5;
            steelFeather.Attack -= 5;
            steelFeather.Lvl = 50;
        }
        public void Eagle()
        {
            RelicDEF eagle = new RelicDEF();
            eagle.NameRelic = "Игла";
            eagle.RelicType = "Элитный";
            eagle.UnitName = "Арбалетчик";
            eagle.ConstructionUnits -= 5;
            eagle.Lvl = 30;
        }
        public void DragonArmor()
        {
            RelicDEF dragonArmor = new RelicDEF();
            dragonArmor.NameRelic = "Панцирь дракона";
            dragonArmor.RelicType = "Элитный";
            dragonArmor.UnitName = "Арбалетчик";
            dragonArmor.Protection += 7.5;
            dragonArmor.Lvl = 30;
        }
        public void ArmorShredDara()
        {
            RelicDEF armorShredDara = new RelicDEF();
            armorShredDara.NameRelic = "Броня Шред-Дара";
            armorShredDara.RelicType = "Особый";
            armorShredDara.UnitName = "Всадник";
            armorShredDara.Protection += 12;
            armorShredDara.Day = 14;
            armorShredDara.Lvl = 30;
        }
        public void LovarHorseshoe()
        {
            RelicDEF lovarHorseshoe = new RelicDEF();
            lovarHorseshoe.NameRelic = "Подкова Ловара";
            lovarHorseshoe.RelicType = "Элитный";
            lovarHorseshoe.UnitName = "Всадник";
            lovarHorseshoe.ConstructionUnits -= 10;
            lovarHorseshoe.Day = 14;
            lovarHorseshoe.Lvl = 30;
        }
        public void ElCartelya()
        {
            RelicDEF elCartelya = new RelicDEF();
            elCartelya.NameRelic = "Эль Картеля";
            elCartelya.RelicType = "Особый";
            elCartelya.UnitName = "Патриарх";
            elCartelya.Protection += 12;
            elCartelya.Day = 14;
            elCartelya.Lvl = 32;
        }
        public void PowerCrystal()
        {
            RelicDEF powerCrystal = new RelicDEF();
            powerCrystal.NameRelic = "Кристалл мощи";
            powerCrystal.RelicType = "Элитный";
            powerCrystal.UnitName = "Патриарх";
            powerCrystal.Protection += 7.5;
            powerCrystal.Day = 14;
            powerCrystal.Lvl = 32;
        }
        public void LiquidFire()
        {
            RelicDEF liquidFire = new RelicDEF();
            liquidFire.NameRelic = "Жидкий огонь";
            liquidFire.RelicType = "Особый";
            liquidFire.UnitName = "Баллиста";
            liquidFire.Protection += 12;
            liquidFire.Day = 14;
            liquidFire.Lvl = 32;
        }
        public void TrollSkull()
        {
            RelicDEF trollSkull = new RelicDEF();
            trollSkull.NameRelic = "Череп тролля";
            trollSkull.RelicType = "Элитный";
            trollSkull.UnitName = "Баллиста";
            trollSkull.Protection += 7.5;
            trollSkull.Lvl = 32;
        }
        public void PoetryHoney()
        {
            RelicDEF poetryHoney = new RelicDEF();
            poetryHoney.NameRelic = "Мед поэзии";
            poetryHoney.RelicType = "Элитный";
            poetryHoney.UnitName = "Следопыт";
            poetryHoney.ConstructionUnits -= 5;
            poetryHoney.Day = 7;
            poetryHoney.Lvl = 38;
        }
        public void DestinyChalk()
        {
            RelicDEF destinyChalk = new RelicDEF();
            destinyChalk.NameRelic = "Мел судьбы";
            destinyChalk.RelicType = "Особый";
            destinyChalk.UnitName = "Охотница";
            destinyChalk.Protection += 12;
            destinyChalk.Day = 14;
            destinyChalk.Lvl = 32;
        }
        public void DominatoraRaincoat()
        {
            RelicDEF dominatoraRaincoat = new RelicDEF();
            dominatoraRaincoat.NameRelic = "Плащ Доминатора";
            dominatoraRaincoat.RelicType = "Элитный";
            dominatoraRaincoat.UnitName = "Охотница";
            dominatoraRaincoat.Protection = +7.5;
            dominatoraRaincoat.Lvl = 38;
        }
        public void ConanKettle()
        {
            RelicDEF conanKettle = new RelicDEF();
            conanKettle.NameRelic = "Котелок Конана";
            conanKettle.RelicType = "Элитный";
            conanKettle.UnitName = "Наездница";
            conanKettle.SpeedConstructionUnits += 6;
            conanKettle.Day = 14;
            conanKettle.Lvl = 40;
        }
        public void DanaLight()
        {
            RelicDEF danaLight = new RelicDEF();
            danaLight.NameRelic = "Свет Даны";
            danaLight.RelicType = "Элитный";
            danaLight.UnitName = "Наездница";
            danaLight.ConstructionUnits -= 6;
            danaLight.Day = 14;
        }
        public void AlHazredRetort()
        {
            RelicDEF alHazredRetort = new RelicDEF();
            alHazredRetort.NameRelic = "Реторта Аль-Хазреда";
            alHazredRetort.RelicType = "Элитный";
            alHazredRetort.UnitName = "Химера";
            alHazredRetort.ConstructionUnits -= 8;
            alHazredRetort.SpeedConstructionUnits -= 5;
            alHazredRetort.Day = 14;
            alHazredRetort.Lvl = 55;
        }
        public void ChePaiSaber()
        {
            RelicDEF chePaiSaber = new RelicDEF();
            chePaiSaber.NameRelic = "Сабля Че-Пая";
            chePaiSaber.RelicType = "Элитный";
            chePaiSaber.UnitName = "Кочевница";
            chePaiSaber.SpeedConstructionUnits += 5;
            chePaiSaber.Day = 7;
            chePaiSaber.Lvl = 32;
        }
        public void GrowthPotion()
        {
            RelicDEF growthPotion = new RelicDEF();
            growthPotion.NameRelic = "Зелье роста";
            growthPotion.RelicType = "Элитный";
            growthPotion.UnitName = "Голем";
            growthPotion.SpeedConstructionUnits += 5;
            growthPotion.Day = 7;
            growthPotion.Lvl = 40;
        }
        public void MagazineMaster()
        {
            RelicDEF magazineMaster = new RelicDEF();
            magazineMaster.NameRelic = "Журнал Магистра";
            magazineMaster.RelicType = "Элитный";
            magazineMaster.UnitName = "Шпион";
            magazineMaster.SpeedConstructionUnits += 5;
            magazineMaster.Day = 7;
            magazineMaster.Lvl = 50;
        }
    }
}
