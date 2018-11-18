using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Атакующие реликвии
/// </summary>
namespace Servers
{
    class RelicOF : BasicRelics
    {
        public void AngerDrop()
        {
            RelicOF angerDrop = new RelicOF();
            angerDrop.NameRelic = "Капли гнева";
            angerDrop.RelicType = "Серийный";
            angerDrop.UnitName = "Копейщик";
            angerDrop.Attack += 4;
            angerDrop.Day = 14;
            angerDrop.Lvl = 24;           
        }        
        public void SignRage()
        {
            RelicOF signRage = new RelicOF();
            signRage.NameRelic = "Знак ярости";
            signRage.RelicType = "Особый";
            signRage.UnitName = "Копейщик";
            signRage.Attack += 2.5;
            signRage.Lvl = 18;            
        }
        public void ForceDrink()
        {
            RelicOF forceDrink = new RelicOF();
            forceDrink.NameRelic = "Напиток силы";
            forceDrink.RelicType = "Серийный";
            forceDrink.UnitName = "Копейщик";
            forceDrink.Attack += 7.5;
            forceDrink.MovementSpeed -= 10;
            forceDrink.Day = 14;
            forceDrink.Lvl = 28;            
        }
        public void BarbarianHelmet()
        {
            RelicOF barbarianHelmet = new RelicOF();
            barbarianHelmet.NameRelic = "Шлем варвара";
            barbarianHelmet.RelicType = "Особый";
            barbarianHelmet.UnitName = "Копейщик";
            barbarianHelmet.Attack += 7.5;
            barbarianHelmet.LoadingCapacity -= 10;
            barbarianHelmet.Lvl = 18;            
        }
        public void IncentiveStaff()
        {
            RelicOF incentiveStaff = new RelicOF();
            incentiveStaff.NameRelic = "Посох стимула";
            incentiveStaff.RelicType = "Серийный";
            incentiveStaff.UnitName = "Копейщик";
            incentiveStaff.Attack += 10;
            incentiveStaff.ConstructionUnits -= 5;
            incentiveStaff.Day += 7;
            incentiveStaff.Lvl = 24;            
        }
        public void BerserkaMask()
        {
            RelicOF berserkaMask = new RelicOF();
            berserkaMask.NameRelic = "Маска Берсерка";
            berserkaMask.RelicType = "Особый";
            berserkaMask.UnitName = "Копейщик";
            berserkaMask.Attack += 7.5;
            berserkaMask.Protection -= 7.5;
            berserkaMask.Lvl = 24;           
        }
        public void ElfinSpear()
        {
            RelicOF elfinSpear = new RelicOF();
            elfinSpear.NameRelic = "Эльфийское копье";
            elfinSpear.RelicType = "Особый";
            elfinSpear.UnitName = "Копейщик";
            elfinSpear.Attack += 7.5;
            elfinSpear.Lvl = 8;           
        }
        public void Fleecer()
        {
            RelicOF fleecer = new RelicOF();
            fleecer.NameRelic = "Живодер";
            fleecer.RelicType = "Серийный";
            fleecer.UnitName = "Копейщик";
            fleecer.Attack += 10;
            fleecer.Day = 3;
            fleecer.Lvl = 18;
        }
        public void TearsEyre()
        {
            RelicOF tearsEyre = new RelicOF();
            tearsEyre.NameRelic = "Слезы Эйр";
            tearsEyre.RelicType = "Серийный";
            tearsEyre.UnitName = "Копейщик";
            tearsEyre.MovementSpeed += 25;
            tearsEyre.LoadingCapacity -= 10;
            tearsEyre.Day = 7;
            tearsEyre.Lvl = 20;
        }
        public void MarchingSmithy()
        {
            RelicOF marchingSmithy = new RelicOF();
            marchingSmithy.NameRelic = "Походная кузница";
            marchingSmithy.RelicType = "Серийный";
            marchingSmithy.UnitName = "Копейщик";
            marchingSmithy.SpeedConstructionUnits += 5;
            marchingSmithy.ConstructionUnits += 10;
            marchingSmithy.Day = 7;
            marchingSmithy.Lvl = 22;
        }
        public void CaptainHorn()
        {
            RelicOF captainHorn = new RelicOF();
            captainHorn.NameRelic = "Горн капитана";
            captainHorn.RelicType = "Особый";
            captainHorn.UnitName = "Копейщик";
            captainHorn.Attack += 10;
            captainHorn.ConstructionUnits -= 5;
            captainHorn.Day = 7;
            captainHorn.Lvl = 22;

        }
        public void AntGod()
        {
            RelicOF antGod = new RelicOF();
            antGod.NameRelic = "Муравьиный бог";
            antGod.RelicType = "Серийный";
            antGod.UnitName = "Паладин";
            antGod.LoadingCapacity += 10;
            antGod.Day = 7;
            antGod.Lvl = 24;
        }
        public void IronWreath()
        {
            RelicOF ironWreath = new RelicOF();
            ironWreath.NameRelic = "Железный венец";
            ironWreath.RelicType = "Элитный";
            ironWreath.UnitName = "Паладин";
            ironWreath.Attack += 10;
            ironWreath.Lvl = 26;
        }
        public void VeyonBanner()
        {
            RelicOF veyonbanner = new RelicOF();
            veyonbanner.NameRelic = "Знамя Вейона";
            veyonbanner.RelicType = "Особый";
            veyonbanner.UnitName = "Паладин";
            veyonbanner.Attack += 10;
            veyonbanner.LoadingCapacity -= 15;
            veyonbanner.Day = 7;
            veyonbanner.Lvl = 28;
        }
        public void GoldAquila()
        {
            RelicOF goldaquila = new RelicOF();
            goldaquila.NameRelic = "Золотая аквила";
            goldaquila.RelicType = "Элитный";
            goldaquila.UnitName = "Паладин";
            goldaquila.MovementSpeed += 25;
            goldaquila.Lvl = 30;
        }
        public void RahnStandard()
        {
            RelicOF rahnStandard = new RelicOF();
            rahnStandard.NameRelic = "Штандарт Рана";
            rahnStandard.RelicType = "Элитный";
            rahnStandard.UnitName = "Рыцарь";
            rahnStandard.Attack += 7.5;
            rahnStandard.MovementSpeed -= 25;
            rahnStandard.Day = 7;
            rahnStandard.Lvl = 26;
        }
        public void EldurFlame()
        {
            RelicOF eldurFlame = new RelicOF();
            eldurFlame.NameRelic = "Пламя Эльдура";
            eldurFlame.RelicType = "Элитный";
            eldurFlame.UnitName = "Рыцарь";
            eldurFlame.Attack += 10;
            eldurFlame.MovementSpeed -= 20;
            eldurFlame.Day = 7;
            eldurFlame.Lvl = 28;
        }
        public void HeavyHarness()
        {
            RelicOF heavyHarness = new RelicOF();
            heavyHarness.NameRelic = "Тяжелая Сбруя";
            heavyHarness.RelicType = "Элитный";
            heavyHarness.UnitName = "Рыцарь";
            heavyHarness.LoadingCapacity += 25;
            heavyHarness.MovementSpeed -= 25;
            heavyHarness.Lvl = 32;
        }
        public void BurnPotion()
        {
            RelicOF burnPotion = new RelicOF();
            burnPotion.NameRelic = "Зелье Берна";
            burnPotion.RelicType = "Особый";
            burnPotion.UnitName = "Грандлорд";
            burnPotion.MovementSpeed += 15;
            burnPotion.Lvl = 34;
        }
        public void BootsDead()
        {
            RelicOF bootsDead = new RelicOF();
            bootsDead.NameRelic = "Сапоги мертвеца";
            bootsDead.RelicType = "Элитный";
            bootsDead.UnitName = "Грандлорд";
            bootsDead.MovementSpeed += 25;
            bootsDead.Day = 7;
            bootsDead.Lvl = 36;
        }
        public void ElChernotopya()
        {
            RelicOF elChernotopya = new RelicOF();
            elChernotopya.NameRelic = "Эль Чернотопья";
            elChernotopya.RelicType = "Особый";
            elChernotopya.UnitName = "Грандлорд";
            elChernotopya.Attack += 7.5;
            elChernotopya.LoadingCapacity -= 10;
            elChernotopya.Day = 7;
            elChernotopya.Lvl = 37;
        }
        public void HorrorMask()
        {
            RelicOF horrorMask = new RelicOF();
            horrorMask.NameRelic = "Маска ужаса";
            horrorMask.RelicType = "Элитный";
            horrorMask.UnitName = "Грандлорд";
            horrorMask.Attack += 10;
            horrorMask.LoadingCapacity -= 10;
            horrorMask.Day = 7;
            horrorMask.Lvl = 38;
        }
        public void NefilimWing()
        {
            RelicOF nefilimWing = new RelicOF();
            nefilimWing.NameRelic = "Крыло Нефилима";
            nefilimWing.RelicType = "Элитный";
            nefilimWing.UnitName = "Чернокнижник";
            nefilimWing.MovementSpeed += 25;
            nefilimWing.Attack -= 10;
            nefilimWing.Day = 7;
            nefilimWing.Lvl = 40;
        }
        public void LevaynThorn()
        {
            RelicOF levaynThorn = new RelicOF();
            levaynThorn.NameRelic = "Шип Левайна";
            levaynThorn.RelicType = "Элитный";
            levaynThorn.UnitName = "Чернокнижник";
            levaynThorn.Attack += 7.5;
            levaynThorn.MovementSpeed -= 25;
            levaynThorn.Day = 7;
            levaynThorn.Lvl = 41;
        }
        public void ChronosEdge()
        {
            RelicOF chronosEdge = new RelicOF();
            chronosEdge.NameRelic = "Лезвие Хроноса";
            chronosEdge.RelicType = "Элитный";
            chronosEdge.UnitName = "Некромант";
            chronosEdge.SpeedConstructionUnits += 5;
            chronosEdge.ConstructionUnits += 7;
            chronosEdge.Day = 14;
            chronosEdge.Lvl = 44;
        }
        public void PozhinatelBuri()
        {
            RelicOF pozhinatelBuri = new RelicOF();
            pozhinatelBuri.NameRelic = "Пожинатель Бури";
            pozhinatelBuri.RelicType = "Элитный";
            pozhinatelBuri.UnitName = "Виверна";
            pozhinatelBuri.MovementSpeed += 25;
            pozhinatelBuri.Lvl = 55;
        }
        public void VeyonArrows()
        {
            RelicOF veyonArrows = new RelicOF();
            veyonArrows.NameRelic = "Стрелы Вейона";
            veyonArrows.RelicType = "Особый";
            veyonArrows.UnitName = "Арбалетчик";
            veyonArrows.Attack += 100;
            veyonArrows.Day = 7;
            veyonArrows.Lvl = 30;
        }
        public void HoneyPotion()
        {
            RelicOF honeyPotion = new RelicOF();
            honeyPotion.NameRelic = "Медовое зелье";
            honeyPotion.RelicType = "Элитный";
            honeyPotion.UnitName = "Всадник";
            honeyPotion.Attack += 100;
            honeyPotion.Day = 7;
            honeyPotion.Lvl = 30;
        }
        public void UlrichSword()
        {
            RelicOF ulrichSword = new RelicOF();
            ulrichSword.NameRelic = "Меч Ульриха";
            ulrichSword.RelicType = "Элитный";
            ulrichSword.UnitName = "Следопыт";
            ulrichSword.Attack = 100;
            ulrichSword.Lvl = 30;
        }
        public void SignFirmness()
        {
            RelicOF signFirmness = new RelicOF();
            signFirmness.NameRelic = "Знак стойкости";
            signFirmness.RelicType = "Особый";
            signFirmness.UnitName = "Следопыт";
            signFirmness.Protection += 7.5;
            signFirmness.Day = 7;
            signFirmness.Lvl = 32;
        }
        public void LovarEye()
        {
            RelicOF lovarEye = new RelicOF();
            lovarEye.NameRelic = "Око Ловара";
            lovarEye.RelicType = "Элитный";
            lovarEye.UnitName = "Охотница";
            lovarEye.MovementSpeed += 25;
            lovarEye.Lvl = 32;
        }
        public void BranHand()
        {
            RelicOF branHand = new RelicOF();
            branHand.NameRelic = "Длань Брана";
            branHand.RelicType = "Элитный";
            branHand.UnitName = "Охотница";
            branHand.ConstructionUnits -= 5;
            branHand.Day = 7;
            branHand.Lvl = 32;
        }
        public void BranWings()
        {
            RelicOF branWings = new RelicOF();
            branWings.NameRelic = "Крылья Брана";
            branWings.RelicType = "Особый";
            branWings.UnitName = "Наездница";
            branWings.MovementSpeed += 25;
            branWings.Lvl = 32;
        }
        public void BloodNight()
        {
            RelicOF bloodNight = new RelicOF();
            bloodNight.NameRelic = "Кровь ночи";
            bloodNight.RelicType = "Особый";
            bloodNight.UnitName = "Наездница";
            bloodNight.MovementSpeed += 25;
            bloodNight.Day = 7;
            bloodNight.Lvl = 38;
        }
        public void Morte()
        {
            RelicOF morte = new RelicOF();
            morte.NameRelic = "Морте";
            morte.RelicType = "Элитный";
            morte.UnitName = "Следопыт";
            morte.Attack += 7.5;
            morte.Lvl = 38;
        }
        public void ArrowsGiven()
        {
            RelicOF arrowsGiven = new RelicOF();
            arrowsGiven.NameRelic = "Стрелы Даны";
            arrowsGiven.RelicType = "Элитный";
            arrowsGiven.UnitName = "Охотница";
            arrowsGiven.Attack += 100;
            arrowsGiven.Day = 7;
            arrowsGiven.Lvl = 38;
        }
        public void BottomlessBag()
        {
            RelicOF bottomlessBag = new RelicOF();
            bottomlessBag.NameRelic = "Бездонная сумка";
            bottomlessBag.RelicType = "Особый";
            bottomlessBag.UnitName = "Охотница";
            bottomlessBag.LoadingCapacity += 50;
            bottomlessBag.Lvl = 38;
        }
        public void MobilizationPlan()
        {
            RelicOF mobilizationPlan = new RelicOF();
            mobilizationPlan.NameRelic = "План мобилизации";
            mobilizationPlan.RelicType = "Элитный";
            mobilizationPlan.UnitName = "Наездница";
            mobilizationPlan.ConstructionUnits -= 6;
            mobilizationPlan.Day = 7;
            mobilizationPlan.Lvl = 40;
        }
        public void RevengeWings()
        {
            RelicOF revengeWings = new RelicOF();
            revengeWings.NameRelic = "Крылья мщения";
            revengeWings.RelicType = "Элитный";
            revengeWings.UnitName = "Наездница";
            revengeWings.LoadingCapacity += 100;
            revengeWings.Lvl = 40;
        }
        public void BlackSun()
        {
            RelicOF blackSun = new RelicOF();
            blackSun.NameRelic = "Черное солнце";
            blackSun.RelicType = "Элитный";
            blackSun.UnitName = "Химера";
            blackSun.ConstructionUnits -= 8;
            blackSun.Day = 7;
            blackSun.Lvl = 55;
        }
        public void SteelBeak()
        {
            RelicOF steelBeak = new RelicOF();
            steelBeak.NameRelic = "Стальной клюв";
            steelBeak.RelicType = "Элитный";
            steelBeak.UnitName = "Химера";
            steelBeak.Attack += 7.5;
            steelBeak.Day = 14;
            steelBeak.Lvl = 55;
        }
        public void LovarClaw()
        {
            RelicOF lovarClaw = new RelicOF();
            lovarClaw.NameRelic = "Коготь Ловара";
            lovarClaw.RelicType = "Элитный";
            lovarClaw.UnitName = "Следопыт";
            lovarClaw.Attack += 7.5;
            lovarClaw.Lvl = 38;

        }
        public void PoisonousClaw()
        {
            RelicOF poisonousClaw = new RelicOF();
            poisonousClaw.NameRelic = "Ядовитый коготь";
            poisonousClaw.RelicType = "Элитный";
            poisonousClaw.UnitName = "Химера";
            poisonousClaw.Attack += 7.5;
            poisonousClaw.Lvl = 55;
        }
    }
}
