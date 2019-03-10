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
    public class RelicOF
    {
        private ConstructionTime constructionTime;

        public RelicOF()
        {
        }
        public RelicOF(ConstructionTime constructionTime)
        {
            this.constructionTime = constructionTime;
        }

        #region AngerDrop
        public BasicRelicOF.AngerDrop[] CreateAngerDrop(int count)
        {
            BasicRelicOF.AngerDrop[] angerDrops = new BasicRelicOF.AngerDrop[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.AngerDrop angerDrop = new BasicRelicOF.AngerDrop(new ConstructionTime() { Day = -14 });


                angerDrop.NameRelic = "Капли гнева";
                angerDrop.RelicType = "Серийный";
                angerDrop.UnitName = "Копейщик";
                angerDrop.Attack += 4;
                angerDrop.Day = 14;
                angerDrop.Lvl = 24;


                angerDrops[k] = angerDrop;
            }
            return angerDrops;
        }
        #endregion

        #region SignRage
        public BasicRelicOF.SignRage[] CreateSignRage(int count)
        {
            BasicRelicOF.SignRage[] signRages = new BasicRelicOF.SignRage[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.SignRage signRage = new BasicRelicOF.SignRage(new ConstructionTime() { });

                signRage.NameRelic = "Знак ярости";
                signRage.RelicType = "Особый";
                signRage.UnitName = "Копейщик";
                signRage.Attack += 2.5;
                signRage.Lvl = 18;

                signRages[k] = signRage;
            }
            return signRages;
        }

        #endregion

        #region ForceDrink
        public BasicRelicOF.ForceDrink[] CreateForceDrink(int count)
        {
            BasicRelicOF.ForceDrink[] forceDrinks = new BasicRelicOF.ForceDrink[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.ForceDrink forceDrink = new BasicRelicOF.ForceDrink(new ConstructionTime() { Day = -14 });

                forceDrink.NameRelic = "Напиток силы";
                forceDrink.RelicType = "Серийный";
                forceDrink.UnitName = "Копейщик";
                forceDrink.Attack += 7.5;
                forceDrink.MovementSpeed -= 10;
                forceDrink.Day -= 14;
                forceDrink.Lvl = 28;

                forceDrinks[k] = forceDrink;

                forceDrinks[k] = forceDrink;
            }
            return forceDrinks;
        }
        #endregion

        #region BarbarianHelmet

        public BasicRelicOF.BarbarianHelmet[] CreateBarbarianHelmet(int count)
        {
            BasicRelicOF.BarbarianHelmet[] barbarianHelmets = new BasicRelicOF.BarbarianHelmet[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BarbarianHelmet barbarianHelmet = new BasicRelicOF.BarbarianHelmet(new ConstructionTime() { });

                barbarianHelmet.NameRelic = "Шлем варвара";
                barbarianHelmet.RelicType = "Особый";
                barbarianHelmet.UnitName = "Копейщик";
                barbarianHelmet.Attack += 7.5;
                barbarianHelmet.LoadingCapacity -= 10;
                barbarianHelmet.Lvl = 18;

                barbarianHelmets[k] = barbarianHelmet;
            }
            return barbarianHelmets;
        }

        #endregion

        #region IncentiveStaff

        public BasicRelicOF.IncentiveStaff[] CreateIncentiveStaff(int count)
        {
            BasicRelicOF.IncentiveStaff[] incentiveStaffs = new BasicRelicOF.IncentiveStaff[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.IncentiveStaff incentiveStaff = new BasicRelicOF.IncentiveStaff(new ConstructionTime() { Day = 7 });

                incentiveStaff.NameRelic = "Посох стимула";
                incentiveStaff.RelicType = "Серийный";
                incentiveStaff.UnitName = "Копейщик";
                incentiveStaff.Attack += 10;
                incentiveStaff.ConstructionUnits -= 5;
                incentiveStaff.Day += 7;
                incentiveStaff.Lvl = 24;

                incentiveStaffs[k] = incentiveStaff;
            }
            return incentiveStaffs;
        }

        #endregion

        #region BerserkaMask
        public BasicRelicOF.BerserkaMask[] CreateBerserkaMask(int count)
        {
            BasicRelicOF.BerserkaMask[] berserkaMasks = new BasicRelicOF.BerserkaMask[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BerserkaMask berserkaMask = new BasicRelicOF.BerserkaMask(new ConstructionTime() { });

                berserkaMask.NameRelic = "Маска Берсерка";
                berserkaMask.RelicType = "Особый";
                berserkaMask.UnitName = "Копейщик";
                berserkaMask.Attack += 7.5;
                berserkaMask.Protection -= 7.5;
                berserkaMask.Lvl = 24;

                berserkaMasks[k] = berserkaMask;
            }
            return berserkaMasks;
        }

        #endregion

        #region ElfinSpear
        public BasicRelicOF.ElfinSpear[] CreateElfinSpear(int count)
        {
            BasicRelicOF.ElfinSpear[] elfinSpears = new BasicRelicOF.ElfinSpear[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.ElfinSpear elfinSpear = new BasicRelicOF.ElfinSpear(new ConstructionTime() { });

                elfinSpear.NameRelic = "Эльфийское копье";
                elfinSpear.RelicType = "Особый";
                elfinSpear.UnitName = "Копейщик";
                elfinSpear.Attack += 7.5;
                elfinSpear.Lvl = 8;

                elfinSpears[k] = elfinSpear;
            }
            return elfinSpears;
        }

        #endregion

        #region Fleecer
        public BasicRelicOF.Fleecer[] CreateFleecer(int count)
        {
            BasicRelicOF.Fleecer[] fleecers = new BasicRelicOF.Fleecer[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.Fleecer fleecer = new BasicRelicOF.Fleecer(new ConstructionTime() { Day = 3 });

                fleecer.NameRelic = "Живодер";
                fleecer.RelicType = "Серийный";
                fleecer.UnitName = "Копейщик";
                fleecer.Attack += 10;
                fleecer.Day = 3;
                fleecer.Lvl = 18;

                fleecers[k] = fleecer;
            }
            return fleecers;
        }

        #endregion

        #region TearsEyre
        public BasicRelicOF.TearsEyre[] CreateTearsEyre(int count)
        {
            BasicRelicOF.TearsEyre[] tearsEyres = new BasicRelicOF.TearsEyre[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.TearsEyre tearsEyre = new BasicRelicOF.TearsEyre(new ConstructionTime() { Day = 7 });

                tearsEyre.NameRelic = "Слезы Эйр";
                tearsEyre.RelicType = "Серийный";
                tearsEyre.UnitName = "Копейщик";
                tearsEyre.MovementSpeed += 25;
                tearsEyre.LoadingCapacity -= 10;
                tearsEyre.Day = 7;
                tearsEyre.Lvl = 20;

                tearsEyres[k] = tearsEyre;
            }
            return tearsEyres;
        }

        #endregion

        #region MarchingSmithy
        public BasicRelicOF.MarchingSmithy[] CreateMarchingSmithy(int count)
        {
            BasicRelicOF.MarchingSmithy[] marchingSmithys = new BasicRelicOF.MarchingSmithy[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.MarchingSmithy marchingSmithy = new BasicRelicOF.MarchingSmithy(new ConstructionTime() { Day = 7 });

                marchingSmithy.NameRelic = "Походная кузница";
                marchingSmithy.RelicType = "Серийный";
                marchingSmithy.UnitName = "Копейщик";
                marchingSmithy.SpeedConstructionUnits += 5;
                marchingSmithy.ConstructionUnits += 10;
                marchingSmithy.Day = 7;
                marchingSmithy.Lvl = 22;

                marchingSmithys[k] = marchingSmithy;
            }
            return marchingSmithys;
        }

        #endregion

        #region CaptainHorn
        public BasicRelicOF.CaptainHorn[] CreateCaptainHorn(int count)
        {
            BasicRelicOF.CaptainHorn[] captainHorns = new BasicRelicOF.CaptainHorn[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.CaptainHorn captainHorn = new BasicRelicOF.CaptainHorn(new ConstructionTime() { Day = 7 });

                captainHorn.NameRelic = "Горн капитана";
                captainHorn.RelicType = "Особый";
                captainHorn.UnitName = "Копейщик";
                captainHorn.Attack += 10;
                captainHorn.ConstructionUnits -= 5;
                captainHorn.Day = 7;
                captainHorn.Lvl = 22;

                captainHorns[k] = captainHorn;
            }
            return captainHorns;
        }


        #endregion

        #region AntGod
        public BasicRelicOF.AntGod[] CreateAntGod(int count)
        {
            BasicRelicOF.AntGod[] antGods = new BasicRelicOF.AntGod[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.AntGod antGod = new BasicRelicOF.AntGod(new ConstructionTime() { Day = 7 });

                antGod.NameRelic = "Муравьиный бог";
                antGod.RelicType = "Серийный";
                antGod.UnitName = "Паладин";
                antGod.LoadingCapacity += 10;
                antGod.Day = 7;
                antGod.Lvl = 24;

                antGods[k] = antGod;
            }
            return antGods;
        }

        #endregion

        #region IronWreath
        public BasicRelicOF.IronWreath[] CreateIronWreath(int count)
        {
            BasicRelicOF.IronWreath[] ironWreaths = new BasicRelicOF.IronWreath[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.IronWreath ironWreath = new BasicRelicOF.IronWreath(new ConstructionTime() { });

                ironWreath.NameRelic = "Железный венец";
                ironWreath.RelicType = "Элитный";
                ironWreath.UnitName = "Паладин";
                ironWreath.Attack += 10;
                ironWreath.Lvl = 26;

                ironWreaths[k] = ironWreath;
            }
            return ironWreaths;
        }

        #endregion

        #region VeyonBanner
        public BasicRelicOF.VeyonBanner[] CreateVeyonBanner(int count)
        {
            BasicRelicOF.VeyonBanner[] veyonbanners = new BasicRelicOF.VeyonBanner[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.VeyonBanner veyonbanner = new BasicRelicOF.VeyonBanner(new ConstructionTime() { Day = 7 });

                veyonbanner.NameRelic = "Знамя Вейона";
                veyonbanner.RelicType = "Особый";
                veyonbanner.UnitName = "Паладин";
                veyonbanner.Attack += 10;
                veyonbanner.LoadingCapacity -= 15;
                veyonbanner.Day = 7;
                veyonbanner.Lvl = 28;

                veyonbanners[k] = veyonbanner;
            }
            return veyonbanners;
        }

        #endregion

        #region GoldAquila
        public BasicRelicOF.GoldAquila[] CreateGoldAquila(int count)
        {
            BasicRelicOF.GoldAquila[] goldaquilas = new BasicRelicOF.GoldAquila[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.GoldAquila goldaquila = new BasicRelicOF.GoldAquila(new ConstructionTime() { });

                goldaquila.NameRelic = "Золотая аквила";
                goldaquila.RelicType = "Элитный";
                goldaquila.UnitName = "Паладин";
                goldaquila.MovementSpeed += 25;
                goldaquila.Lvl = 30;

                goldaquilas[k] = goldaquila;
            }
            return goldaquilas;
        }

        #endregion

        #region RahnStandard
        public BasicRelicOF.RahnStandard[] CreateRahnStandard(int count)
        {
            BasicRelicOF.RahnStandard[] rahnStandards = new BasicRelicOF.RahnStandard[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.RahnStandard rahnStandard = new BasicRelicOF.RahnStandard(new ConstructionTime() { Day = 7 });

                rahnStandard.NameRelic = "Штандарт Рана";
                rahnStandard.RelicType = "Элитный";
                rahnStandard.UnitName = "Рыцарь";
                rahnStandard.Attack += 7.5;
                rahnStandard.MovementSpeed -= 25;
                rahnStandard.Day = 7;
                rahnStandard.Lvl = 26;

                rahnStandards[k] = rahnStandard;
            }
            return rahnStandards;
        }


        #endregion

        #region EldurFlame
        public BasicRelicOF.EldurFlame[] CreateEldurFlame(int count)
        {
            BasicRelicOF.EldurFlame[] eldurFlames = new BasicRelicOF.EldurFlame[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.EldurFlame eldurFlame = new BasicRelicOF.EldurFlame(new ConstructionTime() { Day = 7 });

                eldurFlame.NameRelic = "Пламя Эльдура";
                eldurFlame.RelicType = "Элитный";
                eldurFlame.UnitName = "Рыцарь";
                eldurFlame.Attack += 10;
                eldurFlame.MovementSpeed -= 20;
                eldurFlame.Day = 7;
                eldurFlame.Lvl = 28;

                eldurFlames[k] = eldurFlame;
            }
            return eldurFlames;
        }

        #endregion

        #region HeavyHarness
        public BasicRelicOF.HeavyHarness[] CreateHeavyHarness(int count)
        {
            BasicRelicOF.HeavyHarness[] heavyHarnesss = new BasicRelicOF.HeavyHarness[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.HeavyHarness heavyHarness = new BasicRelicOF.HeavyHarness(new ConstructionTime() { });

                heavyHarness.NameRelic = "Тяжелая Сбруя";
                heavyHarness.RelicType = "Элитный";
                heavyHarness.UnitName = "Рыцарь";
                heavyHarness.LoadingCapacity += 25;
                heavyHarness.MovementSpeed -= 25;
                heavyHarness.Lvl = 32;

                heavyHarnesss[k] = heavyHarness;
            }
            return heavyHarnesss;
        }

        #endregion

        #region BurnPotion
        public BasicRelicOF.BurnPotion[] CreateBurnPotion(int count)
        {
            BasicRelicOF.BurnPotion[] burnPotions = new BasicRelicOF.BurnPotion[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BurnPotion burnPotion = new BasicRelicOF.BurnPotion(new ConstructionTime() { });

                burnPotion.NameRelic = "Зелье Берна";
                burnPotion.RelicType = "Особый";
                burnPotion.UnitName = "Грандлорд";
                burnPotion.MovementSpeed += 15;
                burnPotion.Lvl = 34;

                burnPotions[k] = burnPotion;
            }
            return burnPotions;
        }

        #endregion

        #region BootsDead
        public BasicRelicOF.BootsDead[] CreateBootsDead(int count)
        {
            BasicRelicOF.BootsDead[] bootsDeads = new BasicRelicOF.BootsDead[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BootsDead bootsDead = new BasicRelicOF.BootsDead(new ConstructionTime() { Day = 7 });

                bootsDead.NameRelic = "Сапоги мертвеца";
                bootsDead.RelicType = "Элитный";
                bootsDead.UnitName = "Грандлорд";
                bootsDead.MovementSpeed += 25;
                bootsDead.Day = 7;
                bootsDead.Lvl = 36;

                bootsDeads[k] = bootsDead;
            }
            return bootsDeads;
        }

        #endregion

        #region ElChernotopya
        public BasicRelicOF.ElChernotopya[] CreateElChernotopya(int count)
        {
            BasicRelicOF.ElChernotopya[] elChernotopyas = new BasicRelicOF.ElChernotopya[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.ElChernotopya elChernotopya = new BasicRelicOF.ElChernotopya(new ConstructionTime() { Day = 7 });

                elChernotopya.NameRelic = "Эль Чернотопья";
                elChernotopya.RelicType = "Особый";
                elChernotopya.UnitName = "Грандлорд";
                elChernotopya.Attack += 7.5;
                elChernotopya.LoadingCapacity -= 10;
                elChernotopya.Day = 7;
                elChernotopya.Lvl = 37;

                elChernotopyas[k] = elChernotopya;
            }
            return elChernotopyas;
        }

        #endregion

        #region HorrorMask
        public BasicRelicOF.HorrorMask[] CreateHorrorMask(int count)
        {
            BasicRelicOF.HorrorMask[] horrorMasks = new BasicRelicOF.HorrorMask[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.HorrorMask horrorMask = new BasicRelicOF.HorrorMask(new ConstructionTime() { Day = 7 });

                horrorMask.NameRelic = "Маска ужаса";
                horrorMask.RelicType = "Элитный";
                horrorMask.UnitName = "Грандлорд";
                horrorMask.Attack += 10;
                horrorMask.LoadingCapacity -= 10;
                horrorMask.Day = 7;
                horrorMask.Lvl = 38;

                horrorMasks[k] = horrorMask;
            }
            return horrorMasks;
        }

        #endregion

        #region NefilimWing
        public BasicRelicOF.NefilimWing[] CreateNefilimWing(int count)
        {
            BasicRelicOF.NefilimWing[] nefilimWings = new BasicRelicOF.NefilimWing[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.NefilimWing nefilimWing = new BasicRelicOF.NefilimWing(new ConstructionTime() { Day = 7 });

                nefilimWing.NameRelic = "Крыло Нефилима";
                nefilimWing.RelicType = "Элитный";
                nefilimWing.UnitName = "Чернокнижник";
                nefilimWing.MovementSpeed += 25;
                nefilimWing.Attack -= 10;
                nefilimWing.Day = 7;
                nefilimWing.Lvl = 40;

                nefilimWings[k] = nefilimWing;
            }
            return nefilimWings;
        }

        #endregion

        #region LevaynThorn
        public BasicRelicOF.LevaynThorn[] CreateLevaynThorn(int count)
        {
            BasicRelicOF.LevaynThorn[] levaynThorns = new BasicRelicOF.LevaynThorn[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.LevaynThorn levaynThorn = new BasicRelicOF.LevaynThorn(new ConstructionTime() { Day = 7 });

                levaynThorn.NameRelic = "Шип Левайна";
                levaynThorn.RelicType = "Элитный";
                levaynThorn.UnitName = "Чернокнижник";
                levaynThorn.Attack += 7.5;
                levaynThorn.MovementSpeed -= 25;
                levaynThorn.Day = 7;
                levaynThorn.Lvl = 41;

                levaynThorns[k] = levaynThorn;
            }
            return levaynThorns;
        }

        #endregion

        #region ChronosEdge
        public BasicRelicOF.ChronosEdge[] CreateChronosEdge(int count)
        {
            BasicRelicOF.ChronosEdge[] chronosEdges = new BasicRelicOF.ChronosEdge[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.ChronosEdge chronosEdge = new BasicRelicOF.ChronosEdge(new ConstructionTime() { Day = 14 });

                chronosEdge.NameRelic = "Лезвие Хроноса";
                chronosEdge.RelicType = "Элитный";
                chronosEdge.UnitName = "Некромант";
                chronosEdge.SpeedConstructionUnits += 5;
                chronosEdge.ConstructionUnits += 7;
                chronosEdge.Day = 14;
                chronosEdge.Lvl = 44;

                chronosEdges[k] = chronosEdge;
            }
            return chronosEdges;
        }

        #endregion

        #region PozhinatelBuri
        public BasicRelicOF.PozhinatelBuri[] CreatePozhinatelBuri(int count)
        {
            BasicRelicOF.PozhinatelBuri[] pozhinatelBuris = new BasicRelicOF.PozhinatelBuri[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.PozhinatelBuri pozhinatelBuri = new BasicRelicOF.PozhinatelBuri(new ConstructionTime() { Day = 14 });

                pozhinatelBuri.NameRelic = "Пожинатель Бури";
                pozhinatelBuri.RelicType = "Элитный";
                pozhinatelBuri.UnitName = "Виверна";
                pozhinatelBuri.MovementSpeed += 25;
                pozhinatelBuri.Lvl = 55;

                pozhinatelBuris[k] = pozhinatelBuri;
            }
            return pozhinatelBuris;
        }

        #endregion

        #region VeyonArrows
        public BasicRelicOF.VeyonArrows[] CreateVeyonArrows(int count)
        {
            BasicRelicOF.VeyonArrows[] veyonArrowss = new BasicRelicOF.VeyonArrows[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.VeyonArrows veyonArrows = new BasicRelicOF.VeyonArrows(new ConstructionTime() { Day = 7 });

                veyonArrows.NameRelic = "Стрелы Вейона";
                veyonArrows.RelicType = "Особый";
                veyonArrows.UnitName = "Арбалетчик";
                veyonArrows.Attack += 100;
                veyonArrows.Day = 7;
                veyonArrows.Lvl = 30;

                veyonArrowss[k] = veyonArrows;
            }
            return veyonArrowss;
        }

        #endregion

        #region HoneyPotion
        public BasicRelicOF.HoneyPotion[] CreateHoneyPotion(int count)
        {
            BasicRelicOF.HoneyPotion[] honeyPotions = new BasicRelicOF.HoneyPotion[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.HoneyPotion honeyPotion = new BasicRelicOF.HoneyPotion(new ConstructionTime() { Day = 7 });

                honeyPotion.NameRelic = "Медовое зелье";
                honeyPotion.RelicType = "Элитный";
                honeyPotion.UnitName = "Всадник";
                honeyPotion.Attack += 100;
                honeyPotion.Day = 7;
                honeyPotion.Lvl = 30;

                honeyPotions[k] = honeyPotion;
            }
            return honeyPotions;
        }

        #endregion

        #region UlrichSword
        public BasicRelicOF.UlrichSword[] CreateUlrichSword(int count)
        {
            BasicRelicOF.UlrichSword[] ulrichSwords = new BasicRelicOF.UlrichSword[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.UlrichSword ulrichSword = new BasicRelicOF.UlrichSword(new ConstructionTime() { });

                ulrichSword.NameRelic = "Меч Ульриха";
                ulrichSword.RelicType = "Элитный";
                ulrichSword.UnitName = "Следопыт";
                ulrichSword.Attack = 100;
                ulrichSword.Lvl = 30;

                ulrichSwords[k] = ulrichSword;
            }
            return ulrichSwords;
        }

        #endregion

        #region SignFirmness
        public BasicRelicOF.SignFirmness[] CreateSignFirmness(int count)
        {
            BasicRelicOF.SignFirmness[] signFirmnesss = new BasicRelicOF.SignFirmness[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.SignFirmness signFirmness = new BasicRelicOF.SignFirmness(new ConstructionTime() { });

                signFirmness.NameRelic = "Знак стойкости";
                signFirmness.RelicType = "Особый";
                signFirmness.UnitName = "Следопыт";
                signFirmness.Protection += 7.5;
                signFirmness.Day = 7;
                signFirmness.Lvl = 32;

                signFirmnesss[k] = signFirmness;
            }
            return signFirmnesss;
        }

        #endregion

        #region LovarEye
        public BasicRelicOF.LovarEye[] CreateLovarEye(int count)
        {
            BasicRelicOF.LovarEye[] lovarEyes = new BasicRelicOF.LovarEye[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.LovarEye lovarEye = new BasicRelicOF.LovarEye(new ConstructionTime() { });

                lovarEye.NameRelic = "Око Ловара";
                lovarEye.RelicType = "Элитный";
                lovarEye.UnitName = "Охотница";
                lovarEye.MovementSpeed += 25;
                lovarEye.Lvl = 32;

                lovarEyes[k] = lovarEye;
            }
            return lovarEyes;
        }

        #endregion

        #region BranHand
        public BasicRelicOF.BranHand[] CreateBranHand(int count)
        {
            BasicRelicOF.BranHand[] branHands = new BasicRelicOF.BranHand[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BranHand branHand = new BasicRelicOF.BranHand(new ConstructionTime() { Day = 7 });

                branHand.NameRelic = "Длань Брана";
                branHand.RelicType = "Элитный";
                branHand.UnitName = "Охотница";
                branHand.ConstructionUnits -= 5;
                branHand.Day = 7;
                branHand.Lvl = 32;

                branHands[k] = branHand;
            }
            return branHands;
        }

        #endregion

        #region BranWings
        public BasicRelicOF.BranWings[] CreateBranWings(int count)
        {
            BasicRelicOF.BranWings[] branWingss = new BasicRelicOF.BranWings[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BranWings branWings = new BasicRelicOF.BranWings(new ConstructionTime() { });

                branWings.NameRelic = "Крылья Брана";
                branWings.RelicType = "Особый";
                branWings.UnitName = "Наездница";
                branWings.MovementSpeed += 25;
                branWings.Lvl = 32;

                branWingss[k] = branWings;
            }
            return branWingss;
        }

        #endregion

        #region BloodNight
        public BasicRelicOF.BloodNight[] CreateBloodNight(int count)
        {
            BasicRelicOF.BloodNight[] bloodNights = new BasicRelicOF.BloodNight[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BloodNight bloodNight = new BasicRelicOF.BloodNight(new ConstructionTime() { Day = 7 });

                bloodNight.NameRelic = "Кровь ночи";
                bloodNight.RelicType = "Особый";
                bloodNight.UnitName = "Наездница";
                bloodNight.MovementSpeed += 25;
                bloodNight.Day = 7;
                bloodNight.Lvl = 38;

                bloodNights[k] = bloodNight;
            }
            return bloodNights;
        }

        #endregion

        #region Morte
        public BasicRelicOF.Morte[] CreateMorte(int count)
        {
            BasicRelicOF.Morte[] mortes = new BasicRelicOF.Morte[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.Morte morte = new BasicRelicOF.Morte(new ConstructionTime() { });

                morte.NameRelic = "Морте";
                morte.RelicType = "Элитный";
                morte.UnitName = "Следопыт";
                morte.Attack += 7.5;
                morte.Lvl = 38;

                mortes[k] = morte;
            }
            return mortes;
        }

        #endregion

        #region ArrowsGiven
        public BasicRelicOF.ArrowsGiven[] CreateArrowsGiven(int count)
        {
            BasicRelicOF.ArrowsGiven[] arrowsGivens = new BasicRelicOF.ArrowsGiven[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.ArrowsGiven arrowsGiven = new BasicRelicOF.ArrowsGiven(new ConstructionTime() { });

                arrowsGiven.NameRelic = "Стрелы Даны";
                arrowsGiven.RelicType = "Элитный";
                arrowsGiven.UnitName = "Охотница";
                arrowsGiven.Attack += 100;
                arrowsGiven.Day = 7;
                arrowsGiven.Lvl = 38;

                arrowsGivens[k] = arrowsGiven;
            }
            return arrowsGivens;
        }


        #endregion

        #region BottomlessBag
        public BasicRelicOF.BottomlessBag[] CreateBottomlessBag(int count)
        {
            BasicRelicOF.BottomlessBag[] bottomlessBags = new BasicRelicOF.BottomlessBag[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BottomlessBag bottomlessBag = new BasicRelicOF.BottomlessBag(new ConstructionTime() { });

                bottomlessBag.NameRelic = "Бездонная сумка";
                bottomlessBag.RelicType = "Особый";
                bottomlessBag.UnitName = "Охотница";
                bottomlessBag.LoadingCapacity += 50;
                bottomlessBag.Lvl = 38;

                bottomlessBags[k] = bottomlessBag;
            }
            return bottomlessBags;
        }
        
        #endregion

        #region MobilizationPlan
        public BasicRelicOF.MobilizationPlan[] CreateMobilizationPlan(int count)
        {
            BasicRelicOF.MobilizationPlan[] mobilizationPlans = new BasicRelicOF.MobilizationPlan[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.MobilizationPlan mobilizationPlan = new BasicRelicOF.MobilizationPlan(new ConstructionTime() { Day = 7 });

                mobilizationPlan.NameRelic = "План мобилизации";
                mobilizationPlan.RelicType = "Элитный";
                mobilizationPlan.UnitName = "Наездница";
                mobilizationPlan.ConstructionUnits -= 6;
                mobilizationPlan.Day = 7;
                mobilizationPlan.Lvl = 40;

                mobilizationPlans[k] = mobilizationPlan;
            }
            return mobilizationPlans;
        }

        #endregion

        #region RevengeWings
        public BasicRelicOF.RevengeWings[] CreateRevengeWings(int count)
        {
            BasicRelicOF.RevengeWings[] revengeWingss = new BasicRelicOF.RevengeWings[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.RevengeWings revengeWings = new BasicRelicOF.RevengeWings(new ConstructionTime() { Day = 7 });

                revengeWings.NameRelic = "Крылья мщения";
                revengeWings.RelicType = "Элитный";
                revengeWings.UnitName = "Наездница";
                revengeWings.LoadingCapacity += 100;
                revengeWings.Lvl = 40;

                revengeWingss[k] = revengeWings;
            }
            return revengeWingss;
        }

        #endregion

        #region BlackSun
        public BasicRelicOF.BlackSun[] CreateBlackSun(int count)
        {
            BasicRelicOF.BlackSun[] blackSuns = new BasicRelicOF.BlackSun[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.BlackSun blackSun = new BasicRelicOF.BlackSun(new ConstructionTime() { Day = 7 });

                blackSun.NameRelic = "Черное солнце";
                blackSun.RelicType = "Элитный";
                blackSun.UnitName = "Химера";
                blackSun.ConstructionUnits -= 8;
                blackSun.Day = 7;
                blackSun.Lvl = 55;

                blackSuns[k] = blackSun;
            }
            return blackSuns;
        }

        #endregion

        #region SteelBeak
        public BasicRelicOF.SteelBeak[] CreateSteelBeak(int count)
        {
            BasicRelicOF.SteelBeak[] steelBeaks = new BasicRelicOF.SteelBeak[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.SteelBeak steelBeak = new BasicRelicOF.SteelBeak(new ConstructionTime() { Day = 14 });

                steelBeak.NameRelic = "Стальной клюв";
                steelBeak.RelicType = "Элитный";
                steelBeak.UnitName = "Химера";
                steelBeak.Attack += 7.5;
                steelBeak.Day = 14;
                steelBeak.Lvl = 55;

                steelBeaks[k] = steelBeak;
            }
            return steelBeaks;
        }

        #endregion

        #region LovarClaw
        public BasicRelicOF.LovarClaw[] CreateLovarClaw(int count)
        {
            BasicRelicOF.LovarClaw[] lovarClaws = new BasicRelicOF.LovarClaw[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.LovarClaw lovarClaw = new BasicRelicOF.LovarClaw(new ConstructionTime() { });

                lovarClaw.NameRelic = "Коготь Ловара";
                lovarClaw.RelicType = "Элитный";
                lovarClaw.UnitName = "Следопыт";
                lovarClaw.Attack += 7.5;
                lovarClaw.Lvl = 38;

                lovarClaws[k] = lovarClaw;
            }
            return lovarClaws;
        }

        #endregion

        #region PoisonousClaw
        public BasicRelicOF.PoisonousClaw[] CreatePoisonousClaw(int count)
        {
            BasicRelicOF.PoisonousClaw[] poisonousClaws = new BasicRelicOF.PoisonousClaw[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicOF.PoisonousClaw poisonousClaw = new BasicRelicOF.PoisonousClaw(new ConstructionTime() { });

                poisonousClaw.NameRelic = "Ядовитый коготь";
                poisonousClaw.RelicType = "Элитный";
                poisonousClaw.UnitName = "Химера";
                poisonousClaw.Attack += 7.5;
                poisonousClaw.Lvl = 55;

                poisonousClaws[k] = poisonousClaw;
            }
            return poisonousClaws;
        }

        #endregion

    }
}
