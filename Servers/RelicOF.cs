using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(angerDrop.NameRelic + "\n" + angerDrop.RelicType + "\n" + angerDrop.UnitName + "\n" + "% к атаке: " + angerDrop.Attack + "\n" + "Время действия:" + angerDrop.Day + " дней" + "\n" + "Необходимый уровень: " + angerDrop.Lvl);
        }        
        public void SignRage()
        {
            RelicOF signRage = new RelicOF();
            signRage.NameRelic = "Знак ярости";
            signRage.RelicType = "Особый";
            signRage.UnitName = "Копейщик";
            signRage.Attack += 2.5;
            signRage.Lvl = 18;
            Console.WriteLine(signRage.NameRelic+"\n"+ signRage.RelicType+"\n"+ signRage.UnitName+"\n" + "% к атаке: "+ signRage.Attack+"\n"+ "Необходимый уровень: "+ signRage.Lvl);
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
            Console.WriteLine(forceDrink.NameRelic+"\n"+ forceDrink.RelicType+"\n"+ forceDrink.UnitName+"\n"+"% атаки: "+ forceDrink.Attack+"\n"+"Скорость передвижения : "+ forceDrink.MovementSpeed+"\n"+"Время действия: "+ forceDrink.Day+" дней"+"\n" + "Необходимый уровень: " + forceDrink.Lvl);
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
            Console.WriteLine(barbarianHelmet.NameRelic+"\n"+ barbarianHelmet.RelicType+"\n"+ barbarianHelmet.UnitName+ "\n" + "% атаки: "+ barbarianHelmet.Attack+"\n"+"Грузоподъемность: "+ barbarianHelmet.LoadingCapacity+"\n"+ "Необходимый уровень: " + barbarianHelmet.Lvl);
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
            Console.WriteLine(incentiveStaff.NameRelic+"\n"+ incentiveStaff.RelicType+"\n"+ incentiveStaff.UnitName+"\n"+ "% атаки: " + incentiveStaff.Attack+"\n"+"Скорость постройки: "+ incentiveStaff.ConstructionUnits+"\n"+ "Время действия: "+ incentiveStaff.Day+"\n"+ "Необходимый уровень: " + incentiveStaff.Lvl);
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
            Console.WriteLine(berserkaMask.NameRelic+"\n" + berserkaMask.RelicType+"\n"+ berserkaMask.UnitName+"\n"+ "% атаки: "+ berserkaMask.Attack+"\n"+ "% защиты: "+ berserkaMask.Protection+"\n"+ "Необходимый уровень: "+ berserkaMask.Lvl);
        }
        public void ElfinSpear()
        {
            RelicOF elfinSpear = new RelicOF();
            elfinSpear.NameRelic = "Эльфийское копье";
            elfinSpear.RelicType = "Особый";
            elfinSpear.UnitName = "Копейщик";
            elfinSpear.Attack += 7.5;
            elfinSpear.Lvl = 8;
            Console.WriteLine(elfinSpear.NameRelic+"\n"+ elfinSpear.RelicType+"\n"+ elfinSpear.UnitName+"\n"+ "% атаки: "+ elfinSpear.Attack+"\n"+ "Необходимый уровень: "+ elfinSpear.Lvl);
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
            Console.WriteLine(fleecer.NameRelic+"\n"+ fleecer.RelicType+"\n"+ fleecer.UnitName+"\n"+ "% атаки: "+ fleecer.Attack+"\n"+ "Время действия: " + fleecer.Day+" дня"+"\n"+ "Необходимый уровень: "+ fleecer.Lvl);
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
            Console.WriteLine(tearsEyre.NameRelic+"\n"+ tearsEyre.RelicType+"\n"+ tearsEyre.UnitName+"\n"+ "Скорости передвижения: "+ tearsEyre.MovementSpeed+"\n"+ "Грузоподьёмность: "+ tearsEyre.LoadingCapacity+"\n"+ "Время действия: "+ tearsEyre.Day+" дней"+"\n"+ "Необходимый уровень: "+ tearsEyre.Lvl);
        }
        public void MarchingSmithy()
        {
            RelicOF marchingSmithy = new RelicOF();
            marchingSmithy.NameRelic = "Походная кузница";
            marchingSmithy.RelicType = "Серийный";
            marchingSmithy.UnitName = "Копейщик";
            marchingSmithy.SpeedConstructionUnits += 5;
            marchingSmithy.CostConstructionUnits += 10;
            marchingSmithy.Day = 7;
            marchingSmithy.Lvl = 22;
            Console.WriteLine(marchingSmithy.NameRelic+"\n"+ marchingSmithy.RelicType+"\n"+ marchingSmithy.UnitName+"\n"+ "Cкорость постройки: " + marchingSmithy.SpeedConstructionUnits+"\n"+ "Cтоимость постройки: "+ marchingSmithy.CostConstructionUnits+"\n"+ "Время действия: "+ marchingSmithy.Day+" дней"+"\n"+ "Необходимый уровень: "+ marchingSmithy.Lvl);
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
            Console.WriteLine(captainHorn.NameRelic+"\n"+ captainHorn.RelicType+"\n"+ captainHorn.UnitName+"\n"+ "% атаки: "+ captainHorn.Attack+"\n"+ "Скорость постройки: "+ captainHorn.ConstructionUnits+"\n"+ "Время действия: "+ captainHorn.Day+" дней"+"\n"+ "Необходимый уровень: "+ captainHorn.Lvl);

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
            Console.WriteLine(antGod.NameRelic+"\n"+ antGod.RelicType+"\n"+ antGod.UnitName+"\n"+ "Грузоподьёмность: "+ antGod.LoadingCapacity+"\n"+ "Время действия: "+ antGod.Day+"\n"+ "Необходимый уровень: "+ antGod.Lvl);
        }
        public void IronWreath()
        {
            RelicOF ironWreath = new RelicOF();
            ironWreath.NameRelic = "Железный венец";
            ironWreath.RelicType = "Элитный";
            ironWreath.UnitName = "Паладин";
            ironWreath.Attack += 10;
            ironWreath.Lvl = 26;
            Console.WriteLine(ironWreath.NameRelic+"\n"+ ironWreath.RelicType+"\n"+ ironWreath.UnitName+"\n"+ "% атаки: "+ ironWreath.Attack+"\n"+ "Необходимый уровень: "+ ironWreath.Lvl);
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
            Console.WriteLine(veyonbanner.NameRelic+"\n"+ veyonbanner.RelicType+"\n"+ veyonbanner.UnitName+"\n"+ "% атаки: "+ veyonbanner.Attack+"\n"+ "Грузоподьёмность: "+ veyonbanner.LoadingCapacity+"\n"+ "Время действия: "+ veyonbanner.Day+" дней"+"\n"+ "Необходимый уровень: "+ veyonbanner.Lvl);
        }
        public void GoldAquila()
        {
            RelicOF goldaquila = new RelicOF();
            goldaquila.NameRelic = "Золотая аквила";
            goldaquila.RelicType = "Элитный";
            goldaquila.UnitName = "Паладин";
            goldaquila.MovementSpeed += 25;
            goldaquila.Lvl = 30;
            Console.WriteLine(goldaquila.NameRelic+"\n"+ goldaquila.RelicType+"\n"+ goldaquila.UnitName+"\n"+ "Скорости передвижения: "+ goldaquila.MovementSpeed+"\n"+ "Необходимый уровень: "+ goldaquila.Lvl);
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
            Console.WriteLine(rahnStandard.NameRelic+"\n"+ rahnStandard.RelicType+"\n"+ rahnStandard.UnitName+"\n"+ "% атаки: "+ rahnStandard.Attack+"\n"+ "Скорости передвижения: "+ rahnStandard.MovementSpeed+"\n"+ "Время действия: "+ rahnStandard.Day+" дней"+"\n"+ "Необходимый уровень: "+ rahnStandard.Lvl);
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
            Console.WriteLine(eldurFlame.NameRelic+"\n" +eldurFlame.RelicType+"\n"+ eldurFlame.UnitName+"\n"+ "% атаки: "+ eldurFlame.Attack+"\n"+ "Скорости передвижения: "+ eldurFlame.MovementSpeed+"\n"+ "Время действия: "+ eldurFlame.Day+" дней"+"\n"+ "Необходимый уровень: " + eldurFlame.Lvl);
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
            Console.WriteLine(heavyHarness.NameRelic+"\n"+ heavyHarness.RelicType+"\n"+ heavyHarness.UnitName+"\n"+ "Грузоподьёмность: "+ heavyHarness.LoadingCapacity+"\n"+ "Скорости передвижения: " + heavyHarness.MovementSpeed+"\n"+ "Необходимый уровень: " + heavyHarness.Lvl);
        }
        public void BurnPotion()
        {
            RelicOF burnPotion = new RelicOF();
            burnPotion.NameRelic = "Зелье Берна";
            burnPotion.RelicType = "Особый";
            burnPotion.UnitName = "Грандлорд";
            burnPotion.MovementSpeed += 15;
            burnPotion.Lvl = 34;
            Console.WriteLine(burnPotion.NameRelic+"\n"+ burnPotion.RelicType+"\n"+ burnPotion.UnitName+"\n"+ "Скорости передвижения: " + burnPotion.MovementSpeed+"\n"+ "Необходимый уровень: "+ burnPotion.Lvl);
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
            Console.WriteLine(bootsDead.NameRelic+"\n"+ bootsDead.RelicType+"\n"+ bootsDead.UnitName+"\n"+ "Скорости передвижения: "+ bootsDead.MovementSpeed+"\n"+ "Время действия: " + bootsDead.Day+" дней"+"\n"+ "Необходимый уровень: " + bootsDead.Lvl);
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
            Console.WriteLine(elChernotopya.NameRelic+"\n"+ elChernotopya.RelicType+"\n"+ elChernotopya.UnitName+"\n"+ "% атаки: "+ elChernotopya.Attack+"\n"+ "Грузоподьёмность: "+ elChernotopya.LoadingCapacity+"\n"+ "Время действия: "+ elChernotopya.Day+" дней"+"\n"+ "Необходимый уровень: "+ elChernotopya.Lvl);
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
            Console.WriteLine(horrorMask.NameRelic+"\n"+ horrorMask.RelicType+"\n"+ horrorMask.UnitName+"\n"+ "% атаки: " + horrorMask.Attack+"\n"+ "Грузоподьёмность: " + horrorMask.LoadingCapacity+"\n"+ "Время действия: " + horrorMask.Day+" дней"+"\n"+ "Необходимый уровень: " + horrorMask.Lvl);
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
            Console.WriteLine(nefilimWing.NameRelic+"\n"+ nefilimWing.RelicType+"\n"+ nefilimWing.UnitName+"\n"+ "Скорости передвижения: "+ nefilimWing.MovementSpeed+"\n"+ "% атаки: "+ nefilimWing.Attack+"\n"+ "Время действия: "+ nefilimWing.Day+" дней"+"\n"+ "Необходимый уровень: " + nefilimWing.Lvl);
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
            Console.WriteLine(levaynThorn.NameRelic+"\n"+ levaynThorn.RelicType+"\n"+ levaynThorn.UnitName+"\n"+ "% атаки: " + levaynThorn.Attack+"\n"+ "Скорости передвижения: "+ levaynThorn.MovementSpeed+"\n"+ "Время действия: "+ levaynThorn.Day+" дней"+"\n"+ "Необходимый уровень: " + levaynThorn.Lvl);
        }
        public void ChronosEdge()
        {
            RelicOF chronosEdge = new RelicOF();
            chronosEdge.NameRelic = "Лезвие Хроноса";
            chronosEdge.RelicType = "Элитный";
            chronosEdge.UnitName = "Некромант";
            chronosEdge.SpeedConstructionUnits += 5;
            chronosEdge.CostConstructionUnits += 7;
            chronosEdge.Day = 14;
            chronosEdge.Lvl = 44;
            Console.WriteLine(chronosEdge.NameRelic+"\n"+ chronosEdge.RelicType+"\n"+ chronosEdge.UnitName+"\n"+ "Скорость постройки: "+ chronosEdge.SpeedConstructionUnits + "\n"+ "Стоимости постройки: "+ chronosEdge.CostConstructionUnits+"\n"+ "Время действия: "+ chronosEdge.Day+" дней"+"\n"+ "Необходимый уровень: "+ chronosEdge.Lvl);
        }
        public void PozhinatelBuri()
        {
            RelicOF pozhinatelBuri = new RelicOF();
            pozhinatelBuri.NameRelic = "Пожинатель Бури";
            pozhinatelBuri.RelicType = "Элитный";
            pozhinatelBuri.UnitName = "Виверна";
            pozhinatelBuri.MovementSpeed += 25;
            pozhinatelBuri.Lvl = 55;
            Console.WriteLine(pozhinatelBuri.NameRelic+"\n" + pozhinatelBuri.RelicType+"\n"+ pozhinatelBuri.UnitName+"\n"+ "Скорости передвижения: "+ pozhinatelBuri.MovementSpeed+"\n"+ "Необходимый уровень: "+ pozhinatelBuri.Lvl);
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
            Console.WriteLine(veyonArrows.NameRelic+"\n"+ veyonArrows.RelicType+"\n"+ veyonArrows.UnitName+"\n"+ "% атаки: "+ veyonArrows.Attack+"\n"+ "Время действия: "+ veyonArrows.Day+" дней"+"\n"+ "Необходимый уровень: "+ veyonArrows.Lvl);
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
            Console.WriteLine(honeyPotion.NameRelic+"\n"+ honeyPotion.RelicType+"\n"+ honeyPotion.UnitName+"\n"+ "% атаки: "+ honeyPotion.Attack+"\n"+ "Время действия: "+ honeyPotion.Day+" дней"+"\n"+ "Необходимый уровень: " + honeyPotion.Lvl);
        }
        public void UlrichSword()
        {
            RelicOF ulrichSword = new RelicOF();
            ulrichSword.NameRelic = "Меч Ульриха";
            ulrichSword.RelicType = "Элитный";
            ulrichSword.UnitName = "Следопыт";
            ulrichSword.Attack = 100;
            ulrichSword.Lvl = 30;
            Console.WriteLine(ulrichSword.NameRelic+"\n"+ ulrichSword.RelicType+"\n"+ ulrichSword.UnitName+"\n"+ "% атаки: " + ulrichSword.Attack+"\n"+ "Необходимый уровень: " + ulrichSword.Lvl);
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
            Console.WriteLine(signFirmness.NameRelic+"\n"+ signFirmness.RelicType+"\n"+ signFirmness.UnitName+"\n"+ "% Защиты: "+ signFirmness.Protection+"\n"+ "Время действия: " + signFirmness.Day+" дней"+"\n"+ "Необходимый уровень: " + signFirmness.Lvl);
        }
        public void LovarEye()
        {
            RelicOF lovarEye = new RelicOF();
            lovarEye.NameRelic = "Око Ловара";
            lovarEye.RelicType = "Элитный";
            lovarEye.UnitName = "Охотница";
            lovarEye.MovementSpeed += 25;
            lovarEye.Lvl = 32;
            Console.WriteLine(lovarEye.NameRelic+"\n"+ lovarEye.RelicType+"\n"+ lovarEye.UnitName+"\n"+ "Скорости передвижения: "+ lovarEye.MovementSpeed+"\n"+ "Необходимый уровень: "+ lovarEye.Lvl);
        }
        public void BranHand()
        {
            RelicOF branHand = new RelicOF();
            branHand.NameRelic = "Длань Брана";
            branHand.RelicType = "Элитный";
            branHand.UnitName = "Охотница";
            branHand.CostConstructionUnits -= 5;
            branHand.Day = 7;
            branHand.Lvl = 32;
            Console.WriteLine(branHand.NameRelic+"\n"+ branHand.RelicType+"\n"+ branHand.UnitName+"\n"+ "Стоимости постройки: "+ branHand.CostConstructionUnits+"\n"+ "Время действия: "+ branHand.Day+" дней"+"\n"+ "Необходимый уровень: " + branHand.Lvl);
        }
        public void BranWings()
        {
            RelicOF branWings = new RelicOF();
            branWings.NameRelic = "Крылья Брана";
            branWings.RelicType = "Особый";
            branWings.UnitName = "Наездница";
            branWings.MovementSpeed += 25;
            branWings.Lvl = 32;
            Console.WriteLine(branWings.NameRelic+"\n"+ branWings.RelicType+"\n"+ branWings.UnitName+"\n"+ "Скорости передвижения: "+ branWings.MovementSpeed+"\n" + "Необходимый уровень: " + branWings.Lvl);
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
            Console.WriteLine(bloodNight.NameRelic+"\n"+ bloodNight.RelicType+"\n"+ bloodNight.UnitName+"\n"+ "Скорости передвижения: " + bloodNight.MovementSpeed+"\n"+ "Время действия: "+ bloodNight.Day+" дней"+"\n"+ "Необходимый уровень: " + bloodNight.Lvl);
        }
        public void Morte()
        {
            RelicOF morte = new RelicOF();
            morte.NameRelic = "Морте";
            morte.RelicType = "Элитный";
            morte.UnitName = "Следопыт";
            morte.Attack += 7.5;
            morte.Lvl = 38;
            Console.WriteLine(morte.NameRelic+"\n"+ morte.RelicType+"\n"+ morte.UnitName+"\n"+ "% атаки: "+ morte.Attack+"\n"+ "Необходимый уровень: " + morte.Lvl);
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
            Console.WriteLine(arrowsGiven.NameRelic+"\n"+ arrowsGiven.RelicType+"\n"+ arrowsGiven.UnitName+"\n"+ "% атаки: " + arrowsGiven.Attack+"\n"+ "Время действия: " + arrowsGiven.Day+" дней"+"\n"+ "Необходимый уровень: " + arrowsGiven.Lvl);
        }
        public void BottomlessBag()
        {
            RelicOF bottomlessBag = new RelicOF();
            bottomlessBag.NameRelic = "Бездонная сумка";
            bottomlessBag.RelicType = "Особый";
            bottomlessBag.UnitName = "Охотница";
            bottomlessBag.LoadingCapacity += 50;
            bottomlessBag.Lvl = 38;
            Console.WriteLine(bottomlessBag.NameRelic+"\n"+ bottomlessBag.RelicType+"\n"+ bottomlessBag.UnitName+"\n"+ "Грузоподъемность: " + bottomlessBag.LoadingCapacity+"\n"+ "Необходимый уровень: " + bottomlessBag.Lvl);
        }
        public void MobilizationPlan()
        {
            RelicOF mobilizationPlan = new RelicOF();
            mobilizationPlan.NameRelic = "План мобилизации";
            mobilizationPlan.RelicType = "Элитный";
            mobilizationPlan.UnitName = "Наездница";
            mobilizationPlan.CostConstructionUnits -= 6;
            mobilizationPlan.Day = 7;
            mobilizationPlan.Lvl = 40;
            Console.WriteLine(mobilizationPlan.NameRelic+"\n"+ mobilizationPlan.RelicType+"\n"+ mobilizationPlan.UnitName+"\n"+ "Стоимости постройки: "+ mobilizationPlan.CostConstructionUnits+"\n"+ "Время действия: "+ mobilizationPlan.Day+" дней"+"\n"+ "Необходимый уровень: " + mobilizationPlan.Lvl);
        }
        public void RevengeWings()
        {
            RelicOF revengeWings = new RelicOF();
            revengeWings.NameRelic = "Крылья мщения";
            revengeWings.RelicType = "Элитный";
            revengeWings.UnitName = "Наездница";
            revengeWings.LoadingCapacity += 100;
            revengeWings.Lvl = 40;
            Console.WriteLine(revengeWings.NameRelic+"\n"+ revengeWings.RelicType+"\n"+ revengeWings.UnitName+"\n"+ "Грузоподъемность: " + revengeWings.LoadingCapacity+"\n"+ "Необходимый уровень: " + revengeWings.Lvl);
        }
        public void BlackSun()
        {
            RelicOF blackSun = new RelicOF();
            blackSun.NameRelic = "Черное солнце";
            blackSun.RelicType = "Элитный";
            blackSun.UnitName = "Химера";
            blackSun.CostConstructionUnits -= 8;
            blackSun.Day = 7;
            blackSun.Lvl = 55;
            Console.WriteLine(blackSun.NameRelic+"\n"+ blackSun.RelicType+"\n"+ blackSun.UnitName+"\n"+ "Стоимости постройки: "+ blackSun.CostConstructionUnits+"\n"+ "Время действия: " + blackSun.Day+" дней"+"\n"+ "Необходимый уровень: " + blackSun.Lvl);
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
            Console.WriteLine(steelBeak.NameRelic+"\n"+ steelBeak.RelicType+"\n"+ steelBeak.UnitName+"\n"+ "% атаки: " + steelBeak.Attack+"\n"+ "Время действия: " + steelBeak.Day + " дней" + "\n" + "Необходимый уровень: " + steelBeak.Lvl);
        }
        public void LovarClaw()
        {
            RelicOF lovarClaw = new RelicOF();
            lovarClaw.NameRelic = "Коготь Ловара";
            lovarClaw.RelicType = "Элитный";
            lovarClaw.UnitName = "Следопыт";
            lovarClaw.Attack += 7.5;
            lovarClaw.Lvl = 38;
            Console.WriteLine(lovarClaw.NameRelic+"\n"+ lovarClaw.RelicType+"\n"+ lovarClaw.UnitName+"\n"+ "% атаки: " + lovarClaw.Attack+"\n"+ "Необходимый уровень: " + lovarClaw.Lvl);
        }
        public void PoisonousClaw()
        {
            RelicOF poisonousClaw = new RelicOF();
            poisonousClaw.NameRelic = "Ядовитый коготь";
            poisonousClaw.RelicType = "Элитный";
            poisonousClaw.UnitName = "Химера";
            poisonousClaw.Attack += 7.5;
            poisonousClaw.Lvl = 55;
            Console.WriteLine(poisonousClaw.NameRelic+"\n"+ poisonousClaw.RelicType+"\n"+ poisonousClaw.UnitName+"\n"+ "% атаки: " + poisonousClaw.Attack+"\n"+ "Необходимый уровень: " + poisonousClaw.Lvl);
        }
    }
}
