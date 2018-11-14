using System;
using System.Collections.Generic;
using System.Linq;
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
            angerDrop.Attack = 4;
            angerDrop.Day = 14;
            angerDrop.Lvl = 24;
            Console.WriteLine(angerDrop.NameRelic + "\n" + angerDrop.RelicType + "\n" + angerDrop.UnitName + "\n" + "% к атаке: " + angerDrop.Attack + "\n" + "Время действия:" + angerDrop.Day + " дней" + "\n" + "Необходимый уровень: " + angerDrop.Lvl);
           // return angerDrop.NameRelic + "\n" + angerDrop.RelicType + "\n" + angerDrop.UnitName + "\n" + "% к атаке: " + angerDrop.Attack + "\n" + "Время действия:" + angerDrop.Day + " дней" + "\n" + "Необходимый уровень: " + angerDrop.Lvl;
            
        }        
        public void SignRage()
        {
            RelicOF signRage = new RelicOF();
            signRage.NameRelic = "Знак ярости";
            signRage.RelicType = "Особый";
            signRage.UnitName = "Копейщик";
            signRage.Attack = 2.5;
            signRage.Lvl = 18;
            Console.WriteLine(signRage.NameRelic+"\n"+ signRage.RelicType+"\n"+ signRage.UnitName+"\n" + "% к атаке: "+ signRage.Attack+"\n"+ "Необходимый уровень: "+ signRage.Lvl);
        }
        public void ForceDrink()
        /// <summary>
        /// Напиток силы
        /// </summary>
        {
            RelicOF forceDrink = new RelicOF();
            forceDrink.NameRelic = "Напиток силы";
            forceDrink.RelicType = "Серийный";
            forceDrink.UnitName = "Копейщик";
            forceDrink.Attack = 7.5;
            forceDrink.MovementSpeed = -10;
            forceDrink.Day = 14;
            forceDrink.Lvl = 28;
        }
        public void BarbarianHelmet()
        {
            RelicOF barbarianHelmet = new RelicOF();
            barbarianHelmet.NameRelic = "Шлем варвара";
            barbarianHelmet.RelicType = "Особый";
            barbarianHelmet.UnitName = "Копейщик";
            barbarianHelmet.Attack = 7.5;
            barbarianHelmet.LoadingCapacity = -10;
            barbarianHelmet.Lvl = 18;
        }
        public void IncentiveStaff()
        {
            RelicOF incentiveStaff = new RelicOF();
            incentiveStaff.NameRelic = "Посох стимула";
        }
        public void BerserkaMask()
        {
            RelicOF berserkaMask = new RelicOF();
            berserkaMask.NameRelic = "Маска Берсерка";
        }
        public void ElfinSpear()
        {
            RelicOF elfinSpear = new RelicOF();
            elfinSpear.NameRelic = "Эльфийское копье";
        }
        public void Fleecer()
        {
            RelicOF fleecer = new RelicOF();
            fleecer.NameRelic = "Живодер";
        }
        public void TearsEyre()
        {
            RelicOF tearsEyre = new RelicOF();
            tearsEyre.NameRelic = "Слезы Эйр";
        }
        public void MarchingSmithy()
        {
            RelicOF marchingSmithy = new RelicOF();
            marchingSmithy.NameRelic = "Походная кузница";
        }
        public void CaptainHorn()
        {
            RelicOF captainHorn = new RelicOF();
            captainHorn.NameRelic = "Горн капитана";
        }
        public void AntGod()
        {
            RelicOF antGod = new RelicOF();
            antGod.NameRelic = "Муравьиный бог";
        }
        public void IronWreath()
        {
            RelicOF ironWreath = new RelicOF();
            ironWreath.NameRelic = "Железный венец";
        }
        public void VeyonBanner()
        {
            RelicOF veyonbanner = new RelicOF();
            veyonbanner.NameRelic = "Знамя Вейона";
        }
        public void GoldAquila()
        {
            RelicOF goldaquila = new RelicOF();
            goldaquila.NameRelic = "Золотая аквила";
        }
        public void RahnStandard()
        {
            RelicOF rahnStandard = new RelicOF();
            rahnStandard.NameRelic = "Штандарт Рана";
        }
        public void EldurFlame()
        {
            RelicOF eldurFlame = new RelicOF();
            eldurFlame.NameRelic = "Пламя Эльдура";
        }
        public void HeavyHarness()
        {
            RelicOF heavyHarness = new RelicOF();
            heavyHarness.NameRelic = "Тяжелая Сбруя";
        }
        public void BurnPotion()
        {
            RelicOF burnPotion = new RelicOF();
            burnPotion.NameRelic = "Зелье Берна";
        }
        public void BootsDead()
        {
            RelicOF bootsDead = new RelicOF();
            bootsDead.NameRelic = "Сапоги мертвеца";
        }
        public void ElChernotopya()
        {
            RelicOF elChernotopya = new RelicOF();
            elChernotopya.NameRelic = "Эль Чернотопья";
        }
        public void HorrorMask()
        {
            RelicOF horrorMask = new RelicOF();
            horrorMask.NameRelic = "Маска ужаса";
        }
        public void NefilimWing()
        {
            RelicOF nefilimWing = new RelicOF();
            nefilimWing.NameRelic = "Крыло Нефилима";
        }
        public void LevaynThorn()
        {
            RelicOF levaynThorn = new RelicOF();
            levaynThorn.NameRelic = "Шип Левайна";
        }
        public void ChronosEdge()
        {
            RelicOF chronosEdge = new RelicOF();
            chronosEdge.NameRelic = "Лезвие Хроноса";
        }
        public void PozhinatelBuri()
        {
            RelicOF pozhinatelBuri = new RelicOF();
            pozhinatelBuri.NameRelic = "Пожинатель Бури";
        }
        public void VeyonArrows()
        {
            RelicOF veyonArrows = new RelicOF();
            veyonArrows.NameRelic = "Стрелы Вейона";
        }
        public void HoneyPotion()
        {
            RelicOF honeyPotion = new RelicOF();
            honeyPotion.NameRelic = "Медовое зелье";
        }
        public void UlrichSword()
        {
            RelicOF ulrichSword = new RelicOF();
            ulrichSword.NameRelic = "Меч Ульриха";
        }
        public void SignFirmness()
        {
            RelicOF signFirmness = new RelicOF();
            signFirmness.NameRelic = "Знак стойкости";
        }
        public void LovarEye()
        {
            RelicOF lovarEye = new RelicOF();
            lovarEye.NameRelic = "Око Ловара";
        }
        public void BranHand()
        {
            RelicOF branHand = new RelicOF();
            branHand.NameRelic = "Длань Брана";
        }
        public void BranWings()
        {
            RelicOF branWings = new RelicOF();
            branWings.NameRelic = "Крылья Брана";
        }
        public void BloodNight()
        {
            RelicOF bloodNight = new RelicOF();
            bloodNight.NameRelic = "Кровь ночи";
        }
        public void Morte()
        {
            RelicOF morte = new RelicOF();
            morte.NameRelic = "Морте";
        }
        public void ArrowsGiven()
        {
            RelicOF arrowsGiven = new RelicOF();
            arrowsGiven.NameRelic = "Стрелы Даны";
        }
        public void BottomlessBag()
        {
            RelicOF bottomlessBag = new RelicOF();
            bottomlessBag.NameRelic = "Бездонная сумка";
        }
        public void MobilizationPlan()
        {
            RelicOF mobilizationPlan = new RelicOF();
            mobilizationPlan.NameRelic = "План мобилизации";
        }
        public void RevengeWings()
        {
            RelicOF revengeWings = new RelicOF();
            revengeWings.NameRelic = "Крылья мщения";
        }
        public void BlackSun()
        {
            RelicOF blackSun = new RelicOF();
            blackSun.NameRelic = "Черное солнце";
        }
        public void SteelBeak()
        {
            RelicOF steelBeak = new RelicOF();
            steelBeak.NameRelic = "Стальной клюв";
        }
        public void LovarClaw()
        {
            RelicOF lovarClaw = new RelicOF();
            lovarClaw.NameRelic = "Коготь Ловара";
        }
        public void PoisonousClaw()
        {
            RelicOF poisonousClaw = new RelicOF();
            poisonousClaw.NameRelic = "Ядовитый коготь";
        }

    }
}
