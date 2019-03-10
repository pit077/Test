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
    public class RelicDEF
    {
        private ConstructionTime constructionTime;

        public RelicDEF()
        {
        }

        public RelicDEF(ConstructionTime constructionTime)
        {
            this.constructionTime = constructionTime;
        }

        #region ShlemBrana
        public BasicRelicDEF.ShlemBrana[] CreateShlemBrana(int count)
        {
            BasicRelicDEF.ShlemBrana[] shlemBranas = new BasicRelicDEF.ShlemBrana[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ShlemBrana shlemBrana = new BasicRelicDEF.ShlemBrana(new ConstructionTime() { Day = -14 });

                shlemBrana.NameRelic = "Шлем Брана";
                shlemBrana.RelicType = "Элитный";
                shlemBrana.UnitName = "Всадник";
                shlemBrana.Protection += 8;
                shlemBrana.Lvl = 30;

                shlemBranas[k] = shlemBrana;
            }
            return shlemBranas;
        }

        #endregion

        #region CarePendant
        public BasicRelicDEF.CarePendant[] CreateCarePendant(int count)
        {
            BasicRelicDEF.CarePendant[] carePendants = new BasicRelicDEF.CarePendant[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.CarePendant carePendant = new BasicRelicDEF.CarePendant(new ConstructionTime() { Day = 14 });

                carePendant.NameRelic = "Подвеска осторожности";
                carePendant.RelicType = "Серийный";
                carePendant.Protection += 6;
                carePendant.Day = 14;
                carePendant.Lvl = 18;

                carePendants[k] = carePendant;
            }
            return carePendants;
        }

        #endregion

        #region HonorShoulderStrap
        public BasicRelicDEF.HonorShoulderStrap[] CreateHonorShoulderStrap(int count)
        {
            BasicRelicDEF.HonorShoulderStrap[] honorShoulderStraps = new BasicRelicDEF.HonorShoulderStrap[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.HonorShoulderStrap honorShoulderStrap = new BasicRelicDEF.HonorShoulderStrap(new ConstructionTime() { Day = 14 });

                honorShoulderStrap.NameRelic = "Наплечник чести";
                honorShoulderStrap.RelicType = "Особый";
                honorShoulderStrap.UnitName = "Копейщик";
                honorShoulderStrap.Protection += 7.5;
                honorShoulderStrap.Lvl = 20;

                honorShoulderStraps[k] = honorShoulderStrap;
            }
            return honorShoulderStraps;
        }

        #endregion

        #region ShodBoot
        public BasicRelicDEF.ShodBoot[] CreateShodBoot(int count)
        {
            BasicRelicDEF.ShodBoot[] shodBoots = new BasicRelicDEF.ShodBoot[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ShodBoot shodBoot = new BasicRelicDEF.ShodBoot(new ConstructionTime() { Day = 7 });

                shodBoot.NameRelic = "Кованый сапог";
                shodBoot.RelicType = "Особый";
                shodBoot.UnitName = "Копейщик";
                shodBoot.Protection += 12;
                shodBoot.MovementSpeed -= 25;
                shodBoot.Day = 7;
                shodBoot.Lvl = 22;

                shodBoots[k] = shodBoot;
            }
            return shodBoots;
        }

        #endregion

        #region EyeWyvern
        public BasicRelicDEF.EyeWyvern[] CreateEyeWyvern(int count)
        {
            BasicRelicDEF.EyeWyvern[] eyeWyverns = new BasicRelicDEF.EyeWyvern[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.EyeWyvern eyeWyvern = new BasicRelicDEF.EyeWyvern(new ConstructionTime() { Day = 14 });

                eyeWyvern.NameRelic = "Глаз виверны";
                eyeWyvern.RelicType = "Особый";
                eyeWyvern.UnitName = "Копейщик";
                eyeWyvern.Protection += 12;
                eyeWyvern.ConstructionUnits += 5;
                eyeWyvern.Day = 14;
                eyeWyvern.Lvl = 26;

                eyeWyverns[k] = eyeWyvern;
            }
            return eyeWyverns;
        }

        #endregion

        #region Thistle
        public BasicRelicDEF.Thistle[] CreateThistle(int count)
        {
            BasicRelicDEF.Thistle[] thistles = new BasicRelicDEF.Thistle[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.Thistle thistle = new BasicRelicDEF.Thistle(new ConstructionTime() { });

                thistle.NameRelic = "Чертополох";
                thistle.RelicType = "Особый";
                thistle.UnitName = "Копейщик";
                thistle.Protection += 7.5;
                thistle.Lvl = 30;

                thistles[k] = thistle;
            }
            return thistles;
        }

        #endregion

        #region RunicGuard
        public BasicRelicDEF.RunicGuard[] CreateRunicGuard(int count)
        {
            BasicRelicDEF.RunicGuard[] runicGuards = new BasicRelicDEF.RunicGuard[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.RunicGuard runicGuard = new BasicRelicDEF.RunicGuard(new ConstructionTime() { });

                runicGuard.NameRelic = "Рунический страж";
                runicGuard.RelicType = "Серийный";
                runicGuard.UnitName = "Лучница";
                runicGuard.Protection += 12;
                runicGuard.Day = 14;
                runicGuard.Lvl = 16;

                runicGuards[k] = runicGuard;
            }
            return runicGuards;
        }

        #endregion

        #region ElfinChainArmor
        public BasicRelicDEF.ElfinChainArmor[] CreateElfinChainArmor(int count)
        {
            BasicRelicDEF.ElfinChainArmor[] elfinChainArmors = new BasicRelicDEF.ElfinChainArmor[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ElfinChainArmor elfinChainArmor = new BasicRelicDEF.ElfinChainArmor(new ConstructionTime() { });

                elfinChainArmor.NameRelic = "Эльфийская кольчуга";
                elfinChainArmor.RelicType = "Серийный";
                elfinChainArmor.UnitName = "Лучница";
                elfinChainArmor.Protection += 5;
                elfinChainArmor.Lvl = 18;

                elfinChainArmors[k] = elfinChainArmor;
            }
            return elfinChainArmors;
        }

        #endregion

        #region SignSniper
        public BasicRelicDEF.SignSniper[] CreateSignSniper(int count)
        {
            BasicRelicDEF.SignSniper[] signSnipers = new BasicRelicDEF.SignSniper[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.SignSniper signSniper = new BasicRelicDEF.SignSniper(new ConstructionTime() { Day = 14 });

                signSniper.NameRelic = "Знак снайпера";
                signSniper.RelicType = "Серийный";
                signSniper.UnitName = "Лучница";
                signSniper.Protection += 12;
                signSniper.MovementSpeed -= 25;
                signSniper.Day = 14;
                signSniper.Lvl = 20;

                signSnipers[k] = signSniper;
            }
            return signSnipers;
        }

        #endregion

        #region MifrilovyNaruch
        public BasicRelicDEF.MifrilovyNaruch[] CreateMifrilovyNaruch(int count)
        {
            BasicRelicDEF.MifrilovyNaruch[] mifrilovyNaruchs = new BasicRelicDEF.MifrilovyNaruch[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.MifrilovyNaruch mifrilovyNaruch = new BasicRelicDEF.MifrilovyNaruch(new ConstructionTime() { });

                mifrilovyNaruch.NameRelic = "Мифриловые наручи";
                mifrilovyNaruch.NameRelic = "Особый";
                mifrilovyNaruch.UnitName = "Лучница";
                mifrilovyNaruch.Protection += 7.5;
                mifrilovyNaruch.Attack -= 10;
                mifrilovyNaruch.Lvl = 24;

                mifrilovyNaruchs[k] = mifrilovyNaruch;
            }
            return mifrilovyNaruchs;
        }

        #endregion

        #region SteelBeard
        public BasicRelicDEF.SteelBeard[] CreateSteelBeard(int count)
        {
            BasicRelicDEF.SteelBeard[] steelBeards = new BasicRelicDEF.SteelBeard[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.SteelBeard steelBeard = new BasicRelicDEF.SteelBeard(new ConstructionTime() { Day = 14 });

                steelBeard.NameRelic = "Стальная борода";
                steelBeard.RelicType = "Серийный";
                steelBeard.UnitName = "Гном";
                steelBeard.Protection += 7.5;
                steelBeard.Day = 14;
                steelBeard.Lvl = 24;

                steelBeards[k] = steelBeard;
            }
            return steelBeards;
        }

        #endregion

        #region KonungBoard
        public BasicRelicDEF.KonungBoard[] CreateKonungBoard(int count)
        {
            BasicRelicDEF.KonungBoard[] konungBoards = new BasicRelicDEF.KonungBoard[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.KonungBoard konungBoard = new BasicRelicDEF.KonungBoard(new ConstructionTime() { });

                konungBoard.NameRelic = "Щит конунга";
                konungBoard.RelicType = "Особый";
                konungBoard.UnitName = "Гном";
                konungBoard.Protection += 5;
                konungBoard.Lvl = 26;

                konungBoards[k] = konungBoard;
            }
            return konungBoards;
        }

        #endregion

        #region MarchingBrewery
        public BasicRelicDEF.MarchingBrewery[] CreateMarchingBrewery(int count)
        {
            BasicRelicDEF.MarchingBrewery[] marchingBrewerys = new BasicRelicDEF.MarchingBrewery[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.MarchingBrewery marchingBrewery = new BasicRelicDEF.MarchingBrewery(new ConstructionTime() { Day = 7 });

                marchingBrewery.NameRelic = "Походная пивоварня";
                marchingBrewery.RelicType = "Особый";
                marchingBrewery.UnitName = "Гном";
                marchingBrewery.SpeedConstructionUnits += 5;
                marchingBrewery.Protection += 12;
                marchingBrewery.Day = 7;
                marchingBrewery.Lvl = 28;

                marchingBrewerys[k] = marchingBrewery;
            }
            return marchingBrewerys;
        }

        #endregion

        #region BalinHorn
        public BasicRelicDEF.BalinHorn[] CreateBalinHorn(int count)
        {
            BasicRelicDEF.BalinHorn[] balinHorns = new BasicRelicDEF.BalinHorn[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.BalinHorn balinHorn = new BasicRelicDEF.BalinHorn(new ConstructionTime() { });

                balinHorn.NameRelic = "Рог Балина";
                balinHorn.RelicType = "Особый";
                balinHorn.UnitName = "Гном";
                balinHorn.Protection += 7.5;
                balinHorn.Attack -= 7.5;
                balinHorn.Lvl = 30;

                balinHorns[k] = balinHorn;
            }
            return balinHorns;
        }

        #endregion

        #region OberonSpurs
        public BasicRelicDEF.OberonSpurs[] CreateOberonSpurs(int count)
        {
            BasicRelicDEF.OberonSpurs[] oberonSpurss = new BasicRelicDEF.OberonSpurs[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.OberonSpurs oberonSpurs = new BasicRelicDEF.OberonSpurs(new ConstructionTime() { Day = 7 });

                oberonSpurs.NameRelic = "Шпоры Оберона";
                oberonSpurs.RelicType = "Элитный";
                oberonSpurs.UnitName = "Кочевница";
                oberonSpurs.Protection += 12;
                oberonSpurs.Day = 7;
                oberonSpurs.Lvl = 32;

                oberonSpurss[k] = oberonSpurs;
            }
            return oberonSpurss;
        }

        #endregion

        #region CavalryBoard
        public BasicRelicDEF.CavalryBoard[] CreateCavalryBoard(int count)
        {
            BasicRelicDEF.CavalryBoard[] cavalryBoards = new BasicRelicDEF.CavalryBoard[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.CavalryBoard cavalryBoard = new BasicRelicDEF.CavalryBoard(new ConstructionTime() { Day = 14 });

                cavalryBoard.NameRelic = "Кавалерийский щит";
                cavalryBoard.RelicType = "Элитный";
                cavalryBoard.UnitName = "Кочевница";
                cavalryBoard.Protection += 12;
                cavalryBoard.MovementSpeed -= 25;
                cavalryBoard.Day = 14;
                cavalryBoard.Lvl = 34;

                cavalryBoards[k] = cavalryBoard;
            }
            return cavalryBoards;
        }

        #endregion

        #region DanaCharm
        public BasicRelicDEF.DanaCharm[] CreateDanaCharm(int count)
        {
            BasicRelicDEF.DanaCharm[] danaCharms = new BasicRelicDEF.DanaCharm[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.DanaCharm danaCharm = new BasicRelicDEF.DanaCharm(new ConstructionTime() { Day = 14 });

                danaCharm.NameRelic = "Оберег Даны";
                danaCharm.RelicType = "Особый";
                danaCharm.UnitName = "Кочевница";
                danaCharm.Protection += 10;
                danaCharm.Day = 14;
                danaCharm.Lvl = 32;

                danaCharms[k] = danaCharm;
            }
            return danaCharms;
        }

        #endregion

        #region SkinBear
        public BasicRelicDEF.SkinBear[] CreateSkinBear(int count)
        {
            BasicRelicDEF.SkinBear[] skinBears = new BasicRelicDEF.SkinBear[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.SkinBear skinBear = new BasicRelicDEF.SkinBear(new ConstructionTime() { Day = 7 });

                skinBear.NameRelic = "Шкура медвежутя";
                skinBear.RelicType = "Особый";
                skinBear.UnitName = "Кочевница";
                skinBear.Protection += 12;
                skinBear.MovementSpeed -= 25;
                skinBear.Day = 7;
                skinBear.Lvl = 34;

                skinBears[k] = skinBear;
            }
            return skinBears;
        }

        #endregion

        #region KhanArmor
        public BasicRelicDEF.KhanArmor[] CreateKhanArmor(int count)
        {
            BasicRelicDEF.KhanArmor[] khanArmors = new BasicRelicDEF.KhanArmor[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.KhanArmor khanArmor = new BasicRelicDEF.KhanArmor(new ConstructionTime() { });

                khanArmor.NameRelic = "Броня Хана";
                khanArmor.RelicType = "Элитный";
                khanArmor.UnitName = "Кочевница";
                khanArmor.Protection += 7.5;
                khanArmor.LoadingCapacity -= 30;
                khanArmor.Lvl = 36;

                khanArmors[k] = khanArmor;
            }
            return khanArmors;
        }

        #endregion

        #region RahnBone
        public BasicRelicDEF.RahnBone[] CreateRahnBone(int count)
        {
            BasicRelicDEF.RahnBone[] rahnBones = new BasicRelicDEF.RahnBone[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.RahnBone rahnBone = new BasicRelicDEF.RahnBone(new ConstructionTime() { Day = 7 });

                rahnBone.NameRelic = "Кость Рана";
                rahnBone.RelicType = "Элитный";
                rahnBone.UnitName = "Варвар";
                rahnBone.Protection += 12;
                rahnBone.Day = 7;
                rahnBone.Lvl = 36;

                rahnBones[k] = rahnBone;
            }
            return rahnBones;
        }

        #endregion

        #region AskarTrace
        public BasicRelicDEF.AskarTrace[] CreateAskarTrace(int count)
        {
            BasicRelicDEF.AskarTrace[] askarTraces = new BasicRelicDEF.AskarTrace[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.AskarTrace askarTrace = new BasicRelicDEF.AskarTrace(new ConstructionTime() { });

                askarTrace.NameRelic = "След Аскара";
                askarTrace.RelicType = "Элитный";
                askarTrace.UnitName = "Варвар";
                askarTrace.Protection += 7.5;
                askarTrace.Attack -= 7.5;
                askarTrace.Lvl = 37;

                askarTraces[k] = askarTrace;
            }
            return askarTraces;
        }

        #endregion

        #region PressMary
        public BasicRelicDEF.PressMary[] CreatePressMary(int count)
        {
            BasicRelicDEF.PressMary[] pressMarys = new BasicRelicDEF.PressMary[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.PressMary pressMary = new BasicRelicDEF.PressMary(new ConstructionTime() { Day = 14 });

                pressMary.NameRelic = "Печать Мары";
                pressMary.RelicType = "Элитный";
                pressMary.UnitName = "Голем";
                pressMary.Protection += 7.5;
                pressMary.Day = 14;
                pressMary.Lvl = 38;

                pressMarys[k] = pressMary;
            }
            return pressMarys;
        }

        #endregion

        #region LordRing
        public BasicRelicDEF.LordRing[] CreateLordRing(int count)
        {
            BasicRelicDEF.LordRing[] lordRings = new BasicRelicDEF.LordRing[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.LordRing lordRing = new BasicRelicDEF.LordRing(new ConstructionTime() { });

                lordRing.NameRelic = "Кольцо Владыки";
                lordRing.RelicType = "Элитный";
                lordRing.UnitName = "Голем";
                lordRing.Protection += 5;
                lordRing.Attack -= 5;
                lordRing.Lvl = 39;

                lordRings[k] = lordRing;
            }
            return lordRings;
        }

        #endregion

        #region SpiritFire
        public BasicRelicDEF.SpiritFire[] CreateSpiritFire(int count)
        {
            BasicRelicDEF.SpiritFire[] spiritFires = new BasicRelicDEF.SpiritFire[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.SpiritFire spiritFire = new BasicRelicDEF.SpiritFire(new ConstructionTime() { });

                spiritFire.NameRelic = "Дух Огня";
                spiritFire.RelicType = "Элитный";
                spiritFire.UnitName = "Голем";
                spiritFire.Protection += 5;
                spiritFire.Lvl = 42;

                spiritFires[k] = spiritFire;
            }
            return spiritFires;
        }

        #endregion

        #region MuskMezlikikh
        public BasicRelicDEF.MuskMezlikikh[] CreateMuskMezlikikh(int count)
        {
            BasicRelicDEF.MuskMezlikikh[] muskMezlikikhs = new BasicRelicDEF.MuskMezlikikh[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.MuskMezlikikh muskMezlikikh = new BasicRelicDEF.MuskMezlikikh(new ConstructionTime() { Day = 14 });

                muskMezlikikh.NameRelic = "Маска Безликих";
                muskMezlikikh.RelicType = "Особый";
                muskMezlikikh.AgainstInvestigation += 8;
                muskMezlikikh.Day = 14;
                muskMezlikikh.Lvl = 18;

                muskMezlikikhs[k] = muskMezlikikh;
            }
            return muskMezlikikhs;
        }

        #endregion

        #region ChaosEye
        public BasicRelicDEF.ChaosEye[] CreateChaosEye(int count)
        {
            BasicRelicDEF.ChaosEye[] chaosEyes = new BasicRelicDEF.ChaosEye[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ChaosEye chaosEye = new BasicRelicDEF.ChaosEye(new ConstructionTime() { });

                chaosEye.NameRelic = "Око Хаоса";
                chaosEye.RelicType = "Элитный";
                chaosEye.UnitName = "Шпион";
                chaosEye.Protection += 4;
                chaosEye.Lvl = 20;

                chaosEyes[k] = chaosEye;
            }
            return chaosEyes;
        }

        #endregion

        #region SteelFeather
        public BasicRelicDEF.SteelFeather[] CreateSteelFeather(int count)
        {
            BasicRelicDEF.SteelFeather[] steelFeathers = new BasicRelicDEF.SteelFeather[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.SteelFeather steelFeather = new BasicRelicDEF.SteelFeather(new ConstructionTime() { });

                steelFeather.NameRelic = "Стальное перо";
                steelFeather.RelicType = "Элитный";
                steelFeather.UnitName = "Грифон";
                steelFeather.Protection += 5;
                steelFeather.Attack -= 5;
                steelFeather.Lvl = 50;

                steelFeathers[k] = steelFeather;
            }
            return steelFeathers;
        }

        #endregion

        #region Eagle
        public BasicRelicDEF.Eagle[] CreateEagle(int count)
        {
            BasicRelicDEF.Eagle[] eagles = new BasicRelicDEF.Eagle[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.Eagle eagle = new BasicRelicDEF.Eagle(new ConstructionTime() { });

                eagle.NameRelic = "Игла";
                eagle.RelicType = "Элитный";
                eagle.UnitName = "Арбалетчик";
                eagle.ConstructionUnits -= 5;
                eagle.Lvl = 30;

                eagles[k] = eagle;
            }
            return eagles;
        }

        #endregion

        #region DragonArmor
        public BasicRelicDEF.DragonArmor[] CreateDragonArmor(int count)
        {
            BasicRelicDEF.DragonArmor[] dragonArmors = new BasicRelicDEF.DragonArmor[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.DragonArmor dragonArmor = new BasicRelicDEF.DragonArmor(new ConstructionTime() { });

                dragonArmor.NameRelic = "Панцирь дракона";
                dragonArmor.RelicType = "Элитный";
                dragonArmor.UnitName = "Арбалетчик";
                dragonArmor.Protection += 7.5;
                dragonArmor.Lvl = 30;

                dragonArmors[k] = dragonArmor;
            }
            return dragonArmors;
        }

        #endregion

        #region ArmorShredDara
        public BasicRelicDEF.ArmorShredDara[] CreateArmorShredDara(int count)
        {
            BasicRelicDEF.ArmorShredDara[] armorShredDaras = new BasicRelicDEF.ArmorShredDara[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ArmorShredDara armorShredDara = new BasicRelicDEF.ArmorShredDara(new ConstructionTime() { Day = 14 });

                armorShredDara.NameRelic = "Броня Шред-Дара";
                armorShredDara.RelicType = "Особый";
                armorShredDara.UnitName = "Всадник";
                armorShredDara.Protection += 12;
                armorShredDara.Day = 14;
                armorShredDara.Lvl = 30;

                armorShredDaras[k] = armorShredDara;
            }
            return armorShredDaras;
        }

        #endregion

        #region LovarHorseshoe
        public BasicRelicDEF.LovarHorseshoe[] CreateLovarHorseshoe(int count)
        {
            BasicRelicDEF.LovarHorseshoe[] lovarHorseshoes = new BasicRelicDEF.LovarHorseshoe[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.LovarHorseshoe lovarHorseshoe = new BasicRelicDEF.LovarHorseshoe(new ConstructionTime() { Day = 14 });

                lovarHorseshoe.NameRelic = "Подкова Ловара";
                lovarHorseshoe.RelicType = "Элитный";
                lovarHorseshoe.UnitName = "Всадник";
                lovarHorseshoe.ConstructionUnits -= 10;
                lovarHorseshoe.Day = 14;
                lovarHorseshoe.Lvl = 30;

                lovarHorseshoes[k] = lovarHorseshoe;
            }
            return lovarHorseshoes;
        }

        #endregion

        #region ElCartelya
        public BasicRelicDEF.ElCartelya[] CreateElCartelya(int count)
        {
            BasicRelicDEF.ElCartelya[] elCartelyas = new BasicRelicDEF.ElCartelya[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ElCartelya elCartelya = new BasicRelicDEF.ElCartelya(new ConstructionTime() { Day = 14 });

                elCartelya.NameRelic = "Эль Картеля";
                elCartelya.RelicType = "Особый";
                elCartelya.UnitName = "Патриарх";
                elCartelya.Protection += 12;
                elCartelya.Day = 14;
                elCartelya.Lvl = 32;

                elCartelyas[k] = elCartelya;
            }
            return elCartelyas;
        }

        #endregion

        #region PowerCrystal
        public BasicRelicDEF.PowerCrystal[] CreatePowerCrystal(int count)
        {
            BasicRelicDEF.PowerCrystal[] powerCrystals = new BasicRelicDEF.PowerCrystal[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.PowerCrystal powerCrystal = new BasicRelicDEF.PowerCrystal(new ConstructionTime() { Day = 14 });

                powerCrystal.NameRelic = "Кристалл мощи";
                powerCrystal.RelicType = "Элитный";
                powerCrystal.UnitName = "Патриарх";
                powerCrystal.Protection += 7.5;
                powerCrystal.Day = 14;
                powerCrystal.Lvl = 32;

                powerCrystals[k] = powerCrystal;
            }
            return powerCrystals;
        }

        #endregion

        #region LiquidFire
        public BasicRelicDEF.LiquidFire[] CreateLiquidFire(int count)
        {
            BasicRelicDEF.LiquidFire[] liquidFires = new BasicRelicDEF.LiquidFire[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.LiquidFire liquidFire = new BasicRelicDEF.LiquidFire(new ConstructionTime() { Day = 14 });

                liquidFire.NameRelic = "Жидкий огонь";
                liquidFire.RelicType = "Особый";
                liquidFire.UnitName = "Баллиста";
                liquidFire.Protection += 12;
                liquidFire.Day = 14;
                liquidFire.Lvl = 32;

                liquidFires[k] = liquidFire;
            }
            return liquidFires;
        }

        #endregion

        #region TrollSkull
        public BasicRelicDEF.TrollSkull[] CreateTrollSkull(int count)
        {
            BasicRelicDEF.TrollSkull[] trollSkulls = new BasicRelicDEF.TrollSkull[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.TrollSkull trollSkull = new BasicRelicDEF.TrollSkull(new ConstructionTime() { });

                trollSkull.NameRelic = "Череп тролля";
                trollSkull.RelicType = "Элитный";
                trollSkull.UnitName = "Баллиста";
                trollSkull.Protection += 7.5;
                trollSkull.Lvl = 32;

                trollSkulls[k] = trollSkull;
            }
            return trollSkulls;
        }

        #endregion

        #region PoetryHoney
        public BasicRelicDEF.PoetryHoney[] CreatePoetryHoney(int count)
        {
            BasicRelicDEF.PoetryHoney[] poetryHoneys = new BasicRelicDEF.PoetryHoney[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.PoetryHoney poetryHoney = new BasicRelicDEF.PoetryHoney(new ConstructionTime() { Day = 7 });

                poetryHoney.NameRelic = "Мед поэзии";
                poetryHoney.RelicType = "Элитный";
                poetryHoney.UnitName = "Следопыт";
                poetryHoney.ConstructionUnits -= 5;
                poetryHoney.Day = 7;
                poetryHoney.Lvl = 38;

                poetryHoneys[k] = poetryHoney;
            }
            return poetryHoneys;
        }

        #endregion

        #region DestinyChalk
        public BasicRelicDEF.DestinyChalk[] CreateDestinyChalk(int count)
        {
            BasicRelicDEF.DestinyChalk[] destinyChalks = new BasicRelicDEF.DestinyChalk[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.DestinyChalk destinyChalk = new BasicRelicDEF.DestinyChalk(new ConstructionTime() { Day = 14 });

                destinyChalk.NameRelic = "Мел судьбы";
                destinyChalk.RelicType = "Особый";
                destinyChalk.UnitName = "Охотница";
                destinyChalk.Protection += 12;
                destinyChalk.Day = 14;
                destinyChalk.Lvl = 32;

                destinyChalks[k] = destinyChalk;
            }
            return destinyChalks;
        }

        #endregion

        #region DominatoraRaincoat
        public BasicRelicDEF.DominatoraRaincoat[] CreateDominatoraRaincoat(int count)
        {
            BasicRelicDEF.DominatoraRaincoat[] dominatoraRaincoats = new BasicRelicDEF.DominatoraRaincoat[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.DominatoraRaincoat dominatoraRaincoat = new BasicRelicDEF.DominatoraRaincoat(new ConstructionTime() { });

                dominatoraRaincoat.NameRelic = "Плащ Доминатора";
                dominatoraRaincoat.RelicType = "Элитный";
                dominatoraRaincoat.UnitName = "Охотница";
                dominatoraRaincoat.Protection = +7.5;
                dominatoraRaincoat.Lvl = 38;

                dominatoraRaincoats[k] = dominatoraRaincoat;
            }
            return dominatoraRaincoats;
        }

        #endregion

        #region ConanKettle
        public BasicRelicDEF.ConanKettle[] CreateConanKettle(int count)
        {
            BasicRelicDEF.ConanKettle[] conanKettles = new BasicRelicDEF.ConanKettle[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ConanKettle conanKettle = new BasicRelicDEF.ConanKettle(new ConstructionTime() { Day = 14 });

                conanKettle.NameRelic = "Котелок Конана";
                conanKettle.RelicType = "Элитный";
                conanKettle.UnitName = "Наездница";
                conanKettle.SpeedConstructionUnits += 6;
                conanKettle.Day = 14;
                conanKettle.Lvl = 40;

                conanKettles[k] = conanKettle;
            }
            return conanKettles;
        }

        #endregion

        #region DanaLight
        public BasicRelicDEF.DanaLight[] CreateDanaLight(int count)
        {
            BasicRelicDEF.DanaLight[] danaLights = new BasicRelicDEF.DanaLight[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.DanaLight danaLight = new BasicRelicDEF.DanaLight(new ConstructionTime() { Day = 14 });

                danaLight.NameRelic = "Свет Даны";
                danaLight.RelicType = "Элитный";
                danaLight.UnitName = "Наездница";
                danaLight.ConstructionUnits -= 6;
                danaLight.Day = 14;

                danaLights[k] = danaLight;
            }
            return danaLights;
        }

        #endregion

        #region AlHazredRetort
        public BasicRelicDEF.AlHazredRetort[] CreateAlHazredRetort(int count)
        {
            BasicRelicDEF.AlHazredRetort[] alHazredRetorts = new BasicRelicDEF.AlHazredRetort[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.AlHazredRetort alHazredRetort = new BasicRelicDEF.AlHazredRetort(new ConstructionTime() { Day = 14 });

                alHazredRetort.NameRelic = "Реторта Аль-Хазреда";
                alHazredRetort.RelicType = "Элитный";
                alHazredRetort.UnitName = "Химера";
                alHazredRetort.ConstructionUnits -= 8;
                alHazredRetort.SpeedConstructionUnits -= 5;
                alHazredRetort.Day = 14;
                alHazredRetort.Lvl = 55;

                alHazredRetorts[k] = alHazredRetort;
            }
            return alHazredRetorts;
        }

        #endregion

        #region ChePaiSaber
        public BasicRelicDEF.ChePaiSaber[] CreateChePaiSaber(int count)
        {
            BasicRelicDEF.ChePaiSaber[] chePaiSabers = new BasicRelicDEF.ChePaiSaber[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.ChePaiSaber chePaiSaber = new BasicRelicDEF.ChePaiSaber(new ConstructionTime() { Day = 7 });

                chePaiSaber.NameRelic = "Сабля Че-Пая";
                chePaiSaber.RelicType = "Элитный";
                chePaiSaber.UnitName = "Кочевница";
                chePaiSaber.SpeedConstructionUnits += 5;
                chePaiSaber.Day = 7;
                chePaiSaber.Lvl = 32;

                chePaiSabers[k] = chePaiSaber;
            }
            return chePaiSabers;
        }

        #endregion

        #region GrowthPotion
        public BasicRelicDEF.GrowthPotion[] CreateGrowthPotion(int count)
        {
            BasicRelicDEF.GrowthPotion[] growthPotions = new BasicRelicDEF.GrowthPotion[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.GrowthPotion growthPotion = new BasicRelicDEF.GrowthPotion(new ConstructionTime() { Day = 7 });

                growthPotion.NameRelic = "Зелье роста";
                growthPotion.RelicType = "Элитный";
                growthPotion.UnitName = "Голем";
                growthPotion.SpeedConstructionUnits += 5;
                growthPotion.Day = 7;
                growthPotion.Lvl = 40;

                growthPotions[k] = growthPotion;
            }
            return growthPotions;
        }

        #endregion

        #region MagazineMaster
        public BasicRelicDEF.MagazineMaster[] CreateMagazineMaster(int count)
        {
            BasicRelicDEF.MagazineMaster[] magazineMasters = new BasicRelicDEF.MagazineMaster[count];
            for (int k = 0; k < count; k++)
            {
                BasicRelicDEF.MagazineMaster magazineMaster = new BasicRelicDEF.MagazineMaster(new ConstructionTime() { Day = 7 });

                magazineMaster.NameRelic = "Журнал Магистра";
                magazineMaster.RelicType = "Элитный";
                magazineMaster.UnitName = "Шпион";
                magazineMaster.SpeedConstructionUnits += 5;
                magazineMaster.Day = 7;
                magazineMaster.Lvl = 50;

                magazineMasters[k] = magazineMaster;
            }
            return magazineMasters;
        }

        #endregion

    }
}
