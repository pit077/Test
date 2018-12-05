using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public class WarriorFabric
    {
        #region Пехота   
        #region Нежить
        public BasicInfantry.Indulge[] CreateIndulge(int count)
        {
            BasicInfantry.Indulge[] indulges = new BasicInfantry.Indulge[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Indulge indulge = new BasicInfantry.Indulge(new ConstructionTime() { Min = 0, Sec = 1 });

                indulge.Type = "Пехота";
                indulge.Name = "Нежить";
                indulge.Attack = 50;
                indulge.Infantry = 60;
                indulge.Cavalry = 60;
                indulge.Magistrate = 60;
                indulge.Bestiary = 60;
                indulge.Resources = 40;
                indulge.TraverseSpeed = 12;

                indulges[k] = indulge;

            }
            return indulges;
        }
        #endregion
        #region Копейщик
        public BasicInfantry.Kopeyshchik[] CreateKopeyshik(int count)
        {
            BasicInfantry.Kopeyshchik[] kopeyshchiks = new BasicInfantry.Kopeyshchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Kopeyshchik kopeyshchik = new BasicInfantry.Kopeyshchik(new ConstructionTime() { Min = 5, Sec = 1 });

                kopeyshchik.Type = "Пехота";
                kopeyshchik.Name = "Копейщик";
                kopeyshchik.Attack = 40;
                kopeyshchik.Infantry = 12;
                kopeyshchik.Cavalry = 5;
                kopeyshchik.Magistrate = 5;
                kopeyshchik.Bestiary = 5;
                kopeyshchik.Resources = 20;
                kopeyshchik.Meat = 1;
                kopeyshchik.TraverseSpeed = 6;
                kopeyshchik.gold = 90;
                kopeyshchik.steel = 150;
                kopeyshchik.meats = 60;
                kopeyshchik.sapphires = 7;

                kopeyshchiks[k] = kopeyshchik;

            }
            return kopeyshchiks;
        }
        #endregion
        #region Лучница
        public BasicInfantry.Archeress[] CreateArcheress(int count)
        {
            BasicInfantry.Archeress[] archeresss = new BasicInfantry.Archeress[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Archeress archeress = new BasicInfantry.Archeress(new ConstructionTime() { Min = 3, Sec = 1 });

                archeress.Type = "Пехота";
                archeress.Name = "Лучница";
                archeress.Attack = 10;
                archeress.Infantry = 20;
                archeress.Cavalry = 20;
                archeress.Magistrate = 18;
                archeress.Bestiary = 18;
                archeress.Resources = 10;
                archeress.Meat = 1;
                archeress.TraverseSpeed = 6;
                archeress.gold = 75;
                archeress.steel = 30;
                archeress.meats = 15;
                archeress.sapphires = 7;

                archeresss[k] = archeress;

            }
            return archeresss;
        }
        #endregion
        #region Гном
        public BasicInfantry.Gnome[] CreateGnome(int count)
        {
            BasicInfantry.Gnome[] gnomes = new BasicInfantry.Gnome[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Gnome gnome = new BasicInfantry.Gnome(new ConstructionTime() { Min = 4, Sec = 31 });

                gnome.Type = "Пехота";
                gnome.Name = "Гном";
                gnome.Attack = 15;
                gnome.Infantry = 30;
                gnome.Cavalry = 26;
                gnome.Magistrate = 16;
                gnome.Bestiary = 16;
                gnome.Resources = 13;
                gnome.Meat = 1;
                gnome.TraverseSpeed = 6;
                gnome.gold = 90;
                gnome.steel = 60;
                gnome.meats = 42;
                gnome.sapphires = 8;

                gnomes[k] = gnome;

            }
            return gnomes;
        }
        #endregion
        #region Паладин
        public BasicInfantry.Paladin[] CreatePaladin(int count)
        {
            BasicInfantry.Paladin[] paladins = new BasicInfantry.Paladin[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Paladin paladin = new BasicInfantry.Paladin(new ConstructionTime() { Min = 8, Sec = 1 });

                paladin.Type = "Пехота";
                paladin.Name = "Паладин";
                paladin.Attack = 60;
                paladin.Infantry = 12;
                paladin.Cavalry = 12;
                paladin.Magistrate = 8;
                paladin.Bestiary = 8;
                paladin.Resources = 33;
                paladin.Meat = 1;
                paladin.TraverseSpeed = 12;
                paladin.gold = 100;
                paladin.steel = 270;
                paladin.meats = 150;
                paladin.sapphires = 11;

                paladins[k] = paladin;

            }
            return paladins;
        }
        #endregion
        #region Арбалетчик
        public BasicInfantry.Arbaletchik[] CreateArbArbaletchik(int count)
        {
            BasicInfantry.Arbaletchik[] arbaletchiks = new BasicInfantry.Arbaletchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Arbaletchik arbaletchik = new BasicInfantry.Arbaletchik(new ConstructionTime() { Min = 10, Sec = 1 });

                arbaletchik.Type = "Пехота";
                arbaletchik.Name = "Арбалетчик";
                arbaletchik.Attack = 15;
                arbaletchik.Infantry = 60;
                arbaletchik.Cavalry = 20;
                arbaletchik.Magistrate = 20;
                arbaletchik.Bestiary = 20;
                arbaletchik.Resources = 10;
                arbaletchik.Meat = 2;
                arbaletchik.TraverseSpeed = 12;
                arbaletchik.gold = 140;
                arbaletchik.steel = 90;
                arbaletchik.meats = 200;
                arbaletchik.sapphires = 11;

                arbaletchiks[k] = arbaletchik;

            }
            return arbaletchiks;
        }


        #endregion
        #region Всадник
        public BasicInfantry.Rider[] CreateArbRider(int count)
        {
            BasicInfantry.Rider[] riders = new BasicInfantry.Rider[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Rider rider = new BasicInfantry.Rider(new ConstructionTime() { Min = 10, Sec = 1 });

                rider.Type = "Пехота";
                rider.Name = "Всадник";
                rider.Attack = 15;
                rider.Infantry = 20;
                rider.Cavalry = 60;
                rider.Magistrate = 20;
                rider.Bestiary = 20;
                rider.Resources = 10;
                rider.Meat = 2;
                rider.TraverseSpeed = 12;
                rider.gold = 140;
                rider.steel = 90;
                rider.meats = 200;
                rider.sapphires = 11;

                riders[k] = rider;

            }
            return riders;
        }
        #endregion
        #region Патриарх
        public BasicInfantry.Patriarch[] CreatePatriarch(int count)
        {
            BasicInfantry.Patriarch[] patriarchs = new BasicInfantry.Patriarch[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Patriarch patriarch = new BasicInfantry.Patriarch(new ConstructionTime() { Min = 20, Sec = 1 });

                patriarch.Type = "Пехота";
                patriarch.Name = "Патриарх";
                patriarch.Attack = 30;
                patriarch.Infantry = 40;
                patriarch.Cavalry = 40;
                patriarch.Magistrate = 120;
                patriarch.Bestiary = 40;
                patriarch.Resources = 10;
                patriarch.Meat = 4;
                patriarch.TraverseSpeed = 12;
                patriarch.gold = 280;
                patriarch.steel = 180;
                patriarch.meats = 400;
                patriarch.sapphires = 22;

                patriarchs[k] = patriarch;

            }
            return patriarchs;
        }


        #endregion
        #region Баллиста
        public BasicInfantry.Ballista[] CreateBallista(int count)
        {
            BasicInfantry.Ballista[] ballistas = new BasicInfantry.Ballista[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Ballista ballista = new BasicInfantry.Ballista(new ConstructionTime() { Min = 20, Sec = 1 });

                ballista.Type = "Пехота";
                ballista.Name = "Баллиста";
                ballista.Attack = 30;
                ballista.Infantry = 40;
                ballista.Cavalry = 40;
                ballista.Magistrate = 40;
                ballista.Bestiary = 120;
                ballista.Resources = 10;
                ballista.Meat = 4;
                ballista.TraverseSpeed = 12;
                ballista.gold = 280;
                ballista.steel = 180;
                ballista.meats = 400;
                ballista.sapphires = 22;

                ballistas[k] = ballista;

            }
            return ballistas;
        }
        #endregion
        #region Следопыт
        public BasicInfantry.Pathfinder[] CreatePathfinder(int count)
        {
            BasicInfantry.Pathfinder[] pathfinders = new BasicInfantry.Pathfinder[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Pathfinder pathfinder = new BasicInfantry.Pathfinder(new ConstructionTime() { Min = 10, Sec = 1 });

                pathfinder.Type = "Пехота";
                pathfinder.Name = "Следопыт";
                pathfinder.Attack = 75;
                pathfinder.Infantry = 14;
                pathfinder.Cavalry = 14;
                pathfinder.Magistrate = 14;
                pathfinder.Bestiary = 14;
                pathfinder.Resources = 60;
                pathfinder.Meat = 2;
                pathfinder.TraverseSpeed = 24;
                pathfinder.gold = 300;
                pathfinder.steel = 500;
                pathfinder.meats = 500;
                pathfinder.sapphires = 11;

                pathfinders[k] = pathfinder;

            }
            return pathfinders;
        }
        #endregion
        #region Охотница
        public BasicInfantry.Hunter[] CreateHunter(int count)
        {
            BasicInfantry.Hunter[] hunters = new BasicInfantry.Hunter[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Hunter hunter = new BasicInfantry.Hunter(new ConstructionTime() { Min = 7, Sec = 1 });

                hunter.Type = "Пехота";
                hunter.Name = "Охотница";
                hunter.Attack = 30;
                hunter.Infantry = 30;
                hunter.Cavalry = 30;
                hunter.Magistrate = 30;
                hunter.Bestiary = 30;
                hunter.Resources = 20;
                hunter.Meat = 2;
                hunter.TraverseSpeed = 18;
                hunter.gold = 200;
                hunter.steel = 120;
                hunter.meats = 200;
                hunter.sapphires = 8;

                hunters[k] = hunter;

            }
            return hunters;
        }
        #endregion
        #region Вирсаав
        public BasicInfantry.Virsaav[] CreateVirsaav(int count)
        {
            BasicInfantry.Virsaav[] virsaavs = new BasicInfantry.Virsaav[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Virsaav virsaav = new BasicInfantry.Virsaav(new ConstructionTime() { Min = 12, Sec = 1 });

                virsaav.Type = "Пехота";
                virsaav.Name = "Вирсаав";
                virsaav.Attack = 75;
                virsaav.Infantry = 14;
                virsaav.Cavalry = 14;
                virsaav.Magistrate = 14;
                virsaav.Bestiary = 14;
                virsaav.Resources = 60;
                virsaav.Meat = 1;
                virsaav.TraverseSpeed = 24;
                virsaav.amuletsMary = 250;
                virsaav.sapphires = 16;

                virsaavs[k] = virsaav;

            }
            return virsaavs;
        }
        #endregion
        #region Изгой
        public BasicInfantry.Derelict[] CreateDerelict(int count)
        {
            BasicInfantry.Derelict[] derelicts = new BasicInfantry.Derelict[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Derelict derelict = new BasicInfantry.Derelict(new ConstructionTime() { Min = 5, Sec = 1 });

                derelict.Type = "Пехота";
                derelict.Name = "Изгой";
                derelict.Attack = 15;
                derelict.Infantry = 30;
                derelict.Cavalry = 30;
                derelict.Magistrate = 30;
                derelict.Bestiary = 30;
                derelict.Resources = 20;
                derelict.Meat = 1;
                derelict.TraverseSpeed = 18;
                derelict.amuletsMary = 105;
                derelict.sapphires = 12;

                derelicts[k] = derelict;

            }
            return derelicts;
        }
        #endregion

        #region Имперский копейщик
        public BasicInfantry.ImperialKopeyshchik[] CreateImperialKopeyshchik(int count)
        {
            BasicInfantry.ImperialKopeyshchik[] imperialKopeyshchiks = new BasicInfantry.ImperialKopeyshchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialKopeyshchik imperialKopeyshchik = new BasicInfantry.ImperialKopeyshchik(new ConstructionTime() { Min = 5, Sec = 1 });

                imperialKopeyshchik.Type = "Пехота";
                imperialKopeyshchik.Name = "Имперский копейщик";
                imperialKopeyshchik.Attack = 40;
                imperialKopeyshchik.Infantry = 12;
                imperialKopeyshchik.Cavalry = 5;
                imperialKopeyshchik.Magistrate = 5;
                imperialKopeyshchik.Bestiary = 5;
                imperialKopeyshchik.Resources = 20;
                imperialKopeyshchik.Meat = 1;
                imperialKopeyshchik.TraverseSpeed = 6;
                imperialKopeyshchik.gold = 27;
                imperialKopeyshchik.steel = 45;
                imperialKopeyshchik.meats = 60;
                imperialKopeyshchik.sapphires = 7;

                imperialKopeyshchiks[k] = imperialKopeyshchik;

            }
            return imperialKopeyshchiks;
        }
        #endregion
        #region Имперская лучница
        public BasicInfantry.ImperialArcheress[] CreateImperialArcheress(int count)
        {
            BasicInfantry.ImperialArcheress[] imperialArcheresss = new BasicInfantry.ImperialArcheress[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialArcheress imperialArcheress = new BasicInfantry.ImperialArcheress(new ConstructionTime() { Min = 3, Sec = 1 });

                imperialArcheress.Type = "Пехота";
                imperialArcheress.Name = "Имперская лучница";
                imperialArcheress.Attack = 10;
                imperialArcheress.Infantry = 20;
                imperialArcheress.Cavalry = 20;
                imperialArcheress.Magistrate = 18;
                imperialArcheress.Bestiary = 18;
                imperialArcheress.Resources = 10;
                imperialArcheress.Meat = 1;
                imperialArcheress.TraverseSpeed = 6;
                imperialArcheress.gold = 22;
                imperialArcheress.steel = 9;
                imperialArcheress.meats = 15;
                imperialArcheress.sapphires = 7;

                imperialArcheresss[k] = imperialArcheress;

            }
            return imperialArcheresss;
        }


        #endregion
        #region Имперский гном
        public BasicInfantry.ImperialGnome[] CreateImperialGnome(int count)
        {
            BasicInfantry.ImperialGnome[] imperialGnomes = new BasicInfantry.ImperialGnome[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialGnome imperialGnome = new BasicInfantry.ImperialGnome(new ConstructionTime() { Min = 4, Sec = 31 });

                imperialGnome.Type = "Пехота";
                imperialGnome.Name = "Имперский гном";
                imperialGnome.Attack = 10;
                imperialGnome.Infantry = 20;
                imperialGnome.Cavalry = 20;
                imperialGnome.Magistrate = 18;
                imperialGnome.Bestiary = 18;
                imperialGnome.Resources = 10;
                imperialGnome.Meat = 1;
                imperialGnome.TraverseSpeed = 6;
                imperialGnome.gold = 22;
                imperialGnome.steel = 9;
                imperialGnome.meats = 15;
                imperialGnome.sapphires = 7;

                imperialGnomes[k] = imperialGnome;

            }
            return imperialGnomes;
        }


        #endregion
        #region Имперский паладин
        public BasicInfantry.ImperialPaladin[] CreateImperialPaladin(int count)
        {
            BasicInfantry.ImperialPaladin[] imperialPaladins = new BasicInfantry.ImperialPaladin[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialPaladin imperialPaladin = new BasicInfantry.ImperialPaladin(new ConstructionTime() { Min = 8, Sec = 1 });

                imperialPaladin.Type = "Пехота";
                imperialPaladin.Name = "Имперский паладин";
                imperialPaladin.Attack = 60;
                imperialPaladin.Infantry = 12;
                imperialPaladin.Cavalry = 12;
                imperialPaladin.Magistrate = 8;
                imperialPaladin.Bestiary = 8;
                imperialPaladin.Resources = 33;
                imperialPaladin.Meat = 1;
                imperialPaladin.TraverseSpeed = 12;
                imperialPaladin.gold = 30;
                imperialPaladin.steel = 75;
                imperialPaladin.meats = 45;
                imperialPaladin.sapphires = 11;

                imperialPaladins[k] = imperialPaladin;

            }
            return imperialPaladins;
        }
        #endregion
        #region Имперский арбалетчик
        public BasicInfantry.ImperialArbaletchik[] CreateImperialArbaletchik(int count)
        {
            BasicInfantry.ImperialArbaletchik[] imperialArbaletchiks = new BasicInfantry.ImperialArbaletchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialArbaletchik imperialArbaletchik = new BasicInfantry.ImperialArbaletchik(new ConstructionTime() { Min = 10, Sec = 1 });

                imperialArbaletchik.Type = "Пехота";
                imperialArbaletchik.Name = "Имперский арбалетчик";
                imperialArbaletchik.Attack = 15;
                imperialArbaletchik.Infantry = 60;
                imperialArbaletchik.Cavalry = 20;
                imperialArbaletchik.Magistrate = 20;
                imperialArbaletchik.Bestiary = 20;
                imperialArbaletchik.Resources = 10;
                imperialArbaletchik.Meat = 2;
                imperialArbaletchik.TraverseSpeed = 12;
                imperialArbaletchik.gold = 48;
                imperialArbaletchik.steel = 30;
                imperialArbaletchik.meats = 70;
                imperialArbaletchik.sapphires = 11;

                imperialArbaletchiks[k] = imperialArbaletchik;

            }
            return imperialArbaletchiks;
        }
        #endregion
        #region Имперский всадник
        public BasicInfantry.ImperialRider[] CreateImperialRider(int count)
        {
            BasicInfantry.ImperialRider[] imperialRiders = new BasicInfantry.ImperialRider[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialRider imperialRider = new BasicInfantry.ImperialRider(new ConstructionTime() { Min = 10, Sec = 1 });

                imperialRider.Type = "Пехота";
                imperialRider.Name = "Имперский арбалетчик";
                imperialRider.Attack = 15;
                imperialRider.Infantry = 20;
                imperialRider.Cavalry = 60;
                imperialRider.Magistrate = 20;
                imperialRider.Bestiary = 20;
                imperialRider.Resources = 10;
                imperialRider.Meat = 2;
                imperialRider.TraverseSpeed = 12;
                imperialRider.gold = 48;
                imperialRider.steel = 30;
                imperialRider.meats = 70;
                imperialRider.sapphires = 11;

                imperialRiders[k] = imperialRider;

            }
            return imperialRiders;
        }
        #endregion
        #region Имперский патриарх
        public BasicInfantry.ImperialPatriarch[] CreateImperialPatriarch(int count)
        {
            BasicInfantry.ImperialPatriarch[] imperialPatriarchs = new BasicInfantry.ImperialPatriarch[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialPatriarch imperialPatriarch = new BasicInfantry.ImperialPatriarch(new ConstructionTime() { Min = 20, Sec = 1 });

                imperialPatriarch.Type = "Пехота";
                imperialPatriarch.Name = "Имперский патриарх";
                imperialPatriarch.Attack = 30;
                imperialPatriarch.Infantry = 40;
                imperialPatriarch.Cavalry = 40;
                imperialPatriarch.Magistrate = 120;
                imperialPatriarch.Bestiary = 40;
                imperialPatriarch.Resources = 10;
                imperialPatriarch.Meat = 4;
                imperialPatriarch.TraverseSpeed = 12;
                imperialPatriarch.gold = 96;
                imperialPatriarch.steel = 60;
                imperialPatriarch.meats = 140;
                imperialPatriarch.sapphires = 22;

                imperialPatriarchs[k] = imperialPatriarch;

            }
            return imperialPatriarchs;
        }
        #endregion
        #region Имперская баллиста
        public BasicInfantry.ImperialBallista[] CreateImperialBallista(int count)
        {
            BasicInfantry.ImperialBallista[] imperialBallistas = new BasicInfantry.ImperialBallista[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialBallista imperialBallista = new BasicInfantry.ImperialBallista(new ConstructionTime() { Min = 20, Sec = 1 });

                imperialBallista.Type = "Пехота";
                imperialBallista.Name = "Имперская баллиста";
                imperialBallista.Attack = 30;
                imperialBallista.Infantry = 40;
                imperialBallista.Cavalry = 40;
                imperialBallista.Magistrate = 40;
                imperialBallista.Bestiary = 120;
                imperialBallista.Resources = 10;
                imperialBallista.Meat = 4;
                imperialBallista.TraverseSpeed = 12;
                imperialBallista.gold = 96;
                imperialBallista.steel = 60;
                imperialBallista.meats = 140;
                imperialBallista.sapphires = 22;

                imperialBallistas[k] = imperialBallista;

            }
            return imperialBallistas;
        }
        #endregion
        #region Имперский следопыт
        public BasicInfantry.ImperialPathfinder[] CreateImperialPathfinder(int count)
        {
            BasicInfantry.ImperialPathfinder[] imperialPathfinders = new BasicInfantry.ImperialPathfinder[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialPathfinder imperialPathfinder = new BasicInfantry.ImperialPathfinder(new ConstructionTime() { Min = 10, Sec = 1 });

                imperialPathfinder.Type = "Пехота";
                imperialPathfinder.Name = "Имперский следопыт";
                imperialPathfinder.Attack = 75;
                imperialPathfinder.Infantry = 14;
                imperialPathfinder.Cavalry = 14;
                imperialPathfinder.Magistrate = 14;
                imperialPathfinder.Bestiary = 14;
                imperialPathfinder.Resources = 60;
                imperialPathfinder.Meat = 2;
                imperialPathfinder.TraverseSpeed = 24;
                imperialPathfinder.gold = 100;
                imperialPathfinder.steel = 170;
                imperialPathfinder.meats = 170;
                imperialPathfinder.sapphires = 11;

                imperialPathfinders[k] = imperialPathfinder;

            }
            return imperialPathfinders;
        }
        #endregion
        #region Имперская охотница
        public BasicInfantry.ImperialHunter[] CreateImperialHunter(int count)
        {
            BasicInfantry.ImperialHunter[] imperialHunters = new BasicInfantry.ImperialHunter[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialHunter imperialHunter = new BasicInfantry.ImperialHunter(new ConstructionTime() { Min = 10, Sec = 1 });

                imperialHunter.Type = "Пехота";
                imperialHunter.Name = "Имперская охотница";
                imperialHunter.Attack = 15;
                imperialHunter.Infantry = 30;
                imperialHunter.Cavalry = 30;
                imperialHunter.Magistrate = 30;
                imperialHunter.Bestiary = 30;
                imperialHunter.Resources = 60;
                imperialHunter.Meat = 2;
                imperialHunter.TraverseSpeed = 18;
                imperialHunter.gold = 70;
                imperialHunter.steel = 40;
                imperialHunter.meats = 70;
                imperialHunter.sapphires = 8;

                imperialHunters[k] = imperialHunter;

            }
            return imperialHunters;
        }
        #endregion
        #region Имперский Вирсаав
        public BasicInfantry.ImperialVirsaav[] CreateImperialVirsaav(int count)
        {
            BasicInfantry.ImperialVirsaav[] imperialVirsaavs = new BasicInfantry.ImperialVirsaav[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialVirsaav imperialVirsaav = new BasicInfantry.ImperialVirsaav(new ConstructionTime() { Min = 12, Sec = 1 });

                imperialVirsaav.Type = "Пехота";
                imperialVirsaav.Name = "Имперский Вирсаав";
                imperialVirsaav.Attack = 75;
                imperialVirsaav.Infantry = 14;
                imperialVirsaav.Cavalry = 14;
                imperialVirsaav.Magistrate = 14;
                imperialVirsaav.Bestiary = 14;
                imperialVirsaav.Resources = 60;
                imperialVirsaav.Meat = 1;
                imperialVirsaav.TraverseSpeed = 24;
                imperialVirsaav.amuletsMary = 83;
                imperialVirsaav.sapphires = 5;

                imperialVirsaavs[k] = imperialVirsaav;

            }
            return imperialVirsaavs;
        }
        #endregion
        #region Имперский изгой
        public BasicInfantry.ImperialDerelict[] CreateImperialDerelict(int count)
        {
            BasicInfantry.ImperialDerelict[] imperialDerelicts = new BasicInfantry.ImperialDerelict[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.ImperialDerelict imperialDerelict = new BasicInfantry.ImperialDerelict(new ConstructionTime() { Min = 5, Sec = 1 });

                imperialDerelict.Type = "Пехота";
                imperialDerelict.Name = "Имперский изгой";
                imperialDerelict.Attack = 15;
                imperialDerelict.Infantry = 30;
                imperialDerelict.Cavalry = 30;
                imperialDerelict.Magistrate = 30;
                imperialDerelict.Bestiary = 30;
                imperialDerelict.Resources = 20;
                imperialDerelict.Meat = 1;
                imperialDerelict.TraverseSpeed = 18;
                imperialDerelict.amuletsMary = 35;
                imperialDerelict.sapphires = 5;

                imperialDerelicts[k] = imperialDerelict;

            }
            return imperialDerelicts;
        }
        #endregion

        #region Темный Копейщик
        public BasicInfantry.DarkKopeyshchik[] CreateDarkKopeyshchik(int count)
        {
            BasicInfantry.DarkKopeyshchik[] darkKopeyshchiks = new BasicInfantry.DarkKopeyshchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkKopeyshchik darkKopeyshchik = new BasicInfantry.DarkKopeyshchik(new ConstructionTime() { Min = 0, Sec = 1 });

                darkKopeyshchik.Type = "Пехота";
                darkKopeyshchik.Name = "Темный Копейщик";
                darkKopeyshchik.Attack = 42;
                darkKopeyshchik.Infantry = 13;
                darkKopeyshchik.Cavalry = 5;
                darkKopeyshchik.Magistrate = 5;
                darkKopeyshchik.Bestiary = 5;
                darkKopeyshchik.Resources = 20;
                darkKopeyshchik.Meat = 0.75;
                darkKopeyshchik.TraverseSpeed = 6;
                darkKopeyshchik.sapphires = 7;

                darkKopeyshchiks[k] = darkKopeyshchik;

            }
            return darkKopeyshchiks;
        }
        #endregion
        #region Темная Лучница
        public BasicInfantry.DarkArcheress[] CreateDarkArcheress(int count)
        {
            BasicInfantry.DarkArcheress[] darkArcheresss = new BasicInfantry.DarkArcheress[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkArcheress darkArcheress = new BasicInfantry.DarkArcheress(new ConstructionTime() { Min = 0, Sec = 1 });

                darkArcheress.Type = "Пехота";
                darkArcheress.Name = "Темная Лучница";
                darkArcheress.Attack = 10;
                darkArcheress.Infantry = 21;
                darkArcheress.Cavalry = 21;
                darkArcheress.Magistrate = 19;
                darkArcheress.Bestiary = 19;
                darkArcheress.Resources = 10;
                darkArcheress.Meat = 0.5;
                darkArcheress.TraverseSpeed = 6;
                darkArcheress.sapphires = 7;

                darkArcheresss[k] = darkArcheress;

            }
            return darkArcheresss;
        }
        #endregion
        #region Темный Гном
        public BasicInfantry.DarkGnome[] CreateDarkGnome(int count)
        {
            BasicInfantry.DarkGnome[] darkGnomes = new BasicInfantry.DarkGnome[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkGnome darkGnome = new BasicInfantry.DarkGnome(new ConstructionTime() { Min = 0, Sec = 1 });

                darkGnome.Type = "Пехота";
                darkGnome.Name = "Темный Гном";
                darkGnome.Attack = 16;
                darkGnome.Infantry = 32;
                darkGnome.Cavalry = 27;
                darkGnome.Magistrate = 17;
                darkGnome.Bestiary = 17;
                darkGnome.Resources = 13;
                darkGnome.Meat = 0.5;
                darkGnome.TraverseSpeed = 6;
                darkGnome.sapphires = 8;

                darkGnomes[k] = darkGnome;

            }
            return darkGnomes;
        }
        #endregion
        #region Темный Паладин
        public BasicInfantry.DarkPaladin[] CreateDarkPaladin(int count)
        {
            BasicInfantry.DarkPaladin[] darkPaladins = new BasicInfantry.DarkPaladin[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkPaladin darkPaladin = new BasicInfantry.DarkPaladin(new ConstructionTime() { Min = 0, Sec = 1 });

                darkPaladin.Type = "Пехота";
                darkPaladin.Name = "Темный Паладин";
                darkPaladin.Attack = 63;
                darkPaladin.Infantry = 13;
                darkPaladin.Cavalry = 13;
                darkPaladin.Magistrate = 8;
                darkPaladin.Bestiary = 8;
                darkPaladin.Resources = 33;
                darkPaladin.Meat = 0.75;
                darkPaladin.TraverseSpeed = 12;
                darkPaladin.sapphires = 11;

                darkPaladins[k] = darkPaladin;

            }
            return darkPaladins;
        }
        #endregion
        #region Темный Арбалетчик
        public BasicInfantry.DarkArbaletchik[] CreateDarkArbaletchik(int count)
        {
            BasicInfantry.DarkArbaletchik[] darkArbaletchiks = new BasicInfantry.DarkArbaletchik[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkArbaletchik darkArbaletchik = new BasicInfantry.DarkArbaletchik(new ConstructionTime() { Min = 0, Sec = 1 });

                darkArbaletchik.Type = "Пехота";
                darkArbaletchik.Name = "Темный Арбалетчик";
                darkArbaletchik.Attack = 16;
                darkArbaletchik.Infantry = 63;
                darkArbaletchik.Cavalry = 21;
                darkArbaletchik.Magistrate = 21;
                darkArbaletchik.Bestiary = 21;
                darkArbaletchik.Resources = 10;
                darkArbaletchik.Meat = 1;
                darkArbaletchik.TraverseSpeed = 12;
                darkArbaletchik.sapphires = 11;

                darkArbaletchiks[k] = darkArbaletchik;

            }
            return darkArbaletchiks;
        }
        #endregion
        #region Темный Всадник
        public BasicInfantry.DarkRider[] CreateDarkRider(int count)
        {
            BasicInfantry.DarkRider[] darkRiders = new BasicInfantry.DarkRider[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkRider darkRider = new BasicInfantry.DarkRider(new ConstructionTime() { Min = 0, Sec = 1 });

                darkRider.Type = "Пехота";
                darkRider.Name = "Темный Всадник";
                darkRider.Attack = 16;
                darkRider.Infantry = 21;
                darkRider.Cavalry = 63;
                darkRider.Magistrate = 21;
                darkRider.Bestiary = 21;
                darkRider.Resources = 10;
                darkRider.Meat = 1;
                darkRider.TraverseSpeed = 12;
                darkRider.sapphires = 11;

                darkRiders[k] = darkRider;

            }
            return darkRiders;
        }
        #endregion
        #region Темный Патриарх
        public BasicInfantry.DarkPatriarch[] CreateDarkPatriarch(int count)
        {
            BasicInfantry.DarkPatriarch[] darkPatriarchs = new BasicInfantry.DarkPatriarch[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkPatriarch darkPatriarch = new BasicInfantry.DarkPatriarch(new ConstructionTime() { Min = 0, Sec = 1 });

                darkPatriarch.Type = "Пехота";
                darkPatriarch.Name = "Темный Патриарх";
                darkPatriarch.Attack = 32;
                darkPatriarch.Infantry = 42;
                darkPatriarch.Cavalry = 42;
                darkPatriarch.Magistrate = 126;
                darkPatriarch.Bestiary = 42;
                darkPatriarch.Resources = 10;
                darkPatriarch.Meat = 2;
                darkPatriarch.TraverseSpeed = 12;
                darkPatriarch.sapphires = 22;

                darkPatriarchs[k] = darkPatriarch;

            }
            return darkPatriarchs;
        }
        #endregion
        #region Темная Баллиста
        public BasicInfantry.DarkBallista[] CreateDarkBallista(int count)
        {
            BasicInfantry.DarkBallista[] darkBallistas = new BasicInfantry.DarkBallista[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkBallista darkBallista = new BasicInfantry.DarkBallista(new ConstructionTime() { Min = 0, Sec = 1 });

                darkBallista.Type = "Пехота";
                darkBallista.Name = "Темная Баллиста";
                darkBallista.Attack = 32;
                darkBallista.Infantry = 42;
                darkBallista.Cavalry = 42;
                darkBallista.Magistrate = 42;
                darkBallista.Bestiary = 126;
                darkBallista.Resources = 10;
                darkBallista.Meat = 2;
                darkBallista.TraverseSpeed = 12;
                darkBallista.sapphires = 22;

                darkBallistas[k] = darkBallista;

            }
            return darkBallistas;
        }
        #endregion
        #region Темный Следопыт
        public BasicInfantry.DarkPathfinder[] CreateDarkPathfinder(int count)
        {
            BasicInfantry.DarkPathfinder[] darkPathfinders = new BasicInfantry.DarkPathfinder[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkPathfinder darkPathfinder = new BasicInfantry.DarkPathfinder(new ConstructionTime() { Min = 0, Sec = 1 });

                darkPathfinder.Type = "Пехота";
                darkPathfinder.Name = "Темный Следопыт";
                darkPathfinder.Attack = 79;
                darkPathfinder.Infantry = 15;
                darkPathfinder.Cavalry = 15;
                darkPathfinder.Magistrate = 15;
                darkPathfinder.Bestiary = 15;
                darkPathfinder.Resources = 60;
                darkPathfinder.Meat = 1.5;
                darkPathfinder.TraverseSpeed = 24;
                darkPathfinder.sapphires = 11;

                darkPathfinders[k] = darkPathfinder;

            }
            return darkPathfinders;
        }
        #endregion
        #region Темная Охотница
        public BasicInfantry.DarkHunter[] CreateDarkHunter(int count)
        {
            BasicInfantry.DarkHunter[] darkHunters = new BasicInfantry.DarkHunter[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.DarkHunter darkHunter = new BasicInfantry.DarkHunter(new ConstructionTime() { Min = 0, Sec = 1 });

                darkHunter.Type = "Пехота";
                darkHunter.Name = "Темная Охотница";
                darkHunter.Attack = 16;
                darkHunter.Infantry = 32;
                darkHunter.Cavalry = 32;
                darkHunter.Magistrate = 32;
                darkHunter.Bestiary = 32;
                darkHunter.Resources = 60;
                darkHunter.Meat = 1;
                darkHunter.TraverseSpeed = 18;
                darkHunter.sapphires = 8;

                darkHunters[k] = darkHunter;

            }
            return darkHunters;
        }
        #endregion
        #region Орк
        public BasicInfantry.Ork[] CreateOrk(int count)
        {
            BasicInfantry.Ork[] orks = new BasicInfantry.Ork[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Ork ork = new BasicInfantry.Ork(new ConstructionTime() { Min = 0, Sec = 1 });

                ork.Type = "Пехота";
                ork.Name = "Орк";
                ork.Attack = 20;
                ork.Infantry = 60;
                ork.Cavalry = 20;
                ork.Magistrate = 20;
                ork.Bestiary = 20;
                ork.Resources = 40;

                orks[k] = ork;

            }
            return orks;
        }
        #endregion

        #region Герой
        public BasicInfantry.Hero[] CreateHero(int count)
        {
            BasicInfantry.Hero[] heros = new BasicInfantry.Hero[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Hero hero = new BasicInfantry.Hero(new ConstructionTime() { Min = 0, Sec = 1 });

                hero.Type = "Пехота";
                hero.Name = "Герой";
                hero.Attack = 588;
                hero.Infantry = 294;
                hero.Cavalry = 254;
                hero.Magistrate = 156;
                hero.Bestiary = 156;
                hero.Resources = 1000;
                hero.Meat = 4;
                hero.TraverseSpeed = 33;
                hero.sapphires = 230;

                heros[k] = hero;

            }
            return heros;
        }
        #endregion
        #region Нейт
        public BasicInfantry.Nate[] CreateNate(int count)
        {
            BasicInfantry.Nate[] nates = new BasicInfantry.Nate[count];

            for (int k = 0; k < count; k++)
            {
                BasicInfantry.Nate nate = new BasicInfantry.Nate(new ConstructionTime() { Min = 0, Sec = 1 });

                nate.Type = "Пехота";
                nate.Name = "Нейт";
                nate.Attack = 147;
                nate.Infantry = 294;
                nate.Cavalry = 294;
                nate.Magistrate = 294;
                nate.Bestiary = 294;
                nate.Resources = 1000;
                nate.Meat = 5;
                nate.TraverseSpeed = 27;
                nate.sapphires = 225;

                nates[k] = nate;

            }
            return nates;
        }
        #endregion
        #endregion

        #region Кавалерия
        #region Кочевница
        public BasicCavalry.Nomad[] CreateNomad(int count)
        {
            BasicCavalry.Nomad[] nomads = new BasicCavalry.Nomad[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Nomad nomad = new BasicCavalry.Nomad(new ConstructionTime() { Min = 19, Sec = 1 });

                nomad.Type = "Кавалерия";
                nomad.Name = "Кочевница";
                nomad.Attack = 40;
                nomad.Infantry = 130;
                nomad.Cavalry = 170;
                nomad.Magistrate = 170;
                nomad.Bestiary = 130;
                nomad.Resources = 117;
                nomad.Meat = 2;
                nomad.TraverseSpeed = 18;
                nomad.gold = 880;
                nomad.steel = 350;
                nomad.meats = 530;
                nomad.sapphires = 22;

                nomads[k] = nomad;

            }
            return nomads;
        }
        #endregion
        #region Рыцарь
        public BasicCavalry.Knight[] CreateKnight(int count)
        {
            BasicCavalry.Knight[] knights = new BasicCavalry.Knight[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Knight knight = new BasicCavalry.Knight(new ConstructionTime() { Min = 30, Sec = 1 });

                knight.Type = "Кавалерия";
                knight.Name = "Рыцарь";
                knight.Attack = 240;
                knight.Infantry = 30;
                knight.Cavalry = 80;
                knight.Magistrate = 30;
                knight.Bestiary = 30;
                knight.Resources = 145;
                knight.Meat = 2;
                knight.TraverseSpeed = 18;
                knight.gold = 650;
                knight.steel = 1050;
                knight.meats = 530;
                knight.sapphires = 34;

                knights[k] = knight;
            }
            return knights;
        }
        #endregion
        #region Варвар
        public BasicCavalry.Barbarian[] CreateBarbarian(int count)
        {
            BasicCavalry.Barbarian[] barbarians = new BasicCavalry.Barbarian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Barbarian barbarian = new BasicCavalry.Barbarian(new ConstructionTime() { Min = 19, Sec = 1 });

                barbarian.Type = "Кавалерия";
                barbarian.Name = "Варвар";
                barbarian.Attack = 240;
                barbarian.Infantry = 30;
                barbarian.Cavalry = 80;
                barbarian.Magistrate = 30;
                barbarian.Bestiary = 30;
                barbarian.Resources = 145;
                barbarian.Meat = 2;
                barbarian.TraverseSpeed = 18;
                barbarian.gold = 950;
                barbarian.steel = 570;
                barbarian.meats = 380;
                barbarian.sapphires = 22;

                barbarians[k] = barbarian;
            }
            return barbarians;
        }
        #endregion
        #region Грандлорд
        public BasicCavalry.Grandlord[] CreateGrandlord(int count)
        {
            BasicCavalry.Grandlord[] grandlords = new BasicCavalry.Grandlord[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Grandlord grandlord = new BasicCavalry.Grandlord(new ConstructionTime() { Min = 45, Sec = 1 });

                grandlord.Type = "Кавалерия";
                grandlord.Name = "Грандлорд";
                grandlord.Attack = 360;
                grandlord.Infantry = 80;
                grandlord.Cavalry = 30;
                grandlord.Magistrate = 30;
                grandlord.Bestiary = 30;
                grandlord.Resources = 239;
                grandlord.Meat = 2;
                grandlord.TraverseSpeed = 12;
                grandlord.gold = 720;
                grandlord.steel = 1800;
                grandlord.meats = 1000;
                grandlord.sapphires = 51;

                grandlords[k] = grandlord;
            }
            return grandlords;
        }
        #endregion
        #region Наездница
        public BasicCavalry.Equestrian[] CreateEquestrian(int count)
        {
            BasicCavalry.Equestrian[] equestrians = new BasicCavalry.Equestrian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Equestrian equestrian = new BasicCavalry.Equestrian(new ConstructionTime() { Min = 45, Sec = 1 });

                equestrian.Type = "Кавалерия";
                equestrian.Name = "Наездница";
                equestrian.Attack = 360;
                equestrian.Infantry = 30;
                equestrian.Cavalry = 40;
                equestrian.Magistrate = 40;
                equestrian.Bestiary = 40;
                equestrian.Resources = 250;
                equestrian.Meat = 2;
                equestrian.TraverseSpeed = 20;
                equestrian.gold = 1200;
                equestrian.steel = 2100;
                equestrian.meats = 2100;
                equestrian.sapphires = 51; // уточнить

                equestrians[k] = equestrian;
            }
            return equestrians;
        }
        #endregion
        #region Рейтар
        public BasicCavalry.Reytar[] CreateReytar(int count)
        {
            BasicCavalry.Reytar[] reytars = new BasicCavalry.Reytar[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Reytar reytar = new BasicCavalry.Reytar(new ConstructionTime() { Min = 23, Sec = 1 });

                reytar.Type = "Кавалерия";
                reytar.Name = "Рейтар";
                reytar.Attack = 50;
                reytar.Infantry = 150;
                reytar.Cavalry = 150;
                reytar.Magistrate = 150;
                reytar.Bestiary = 150;
                reytar.Resources = 117;
                reytar.Meat = 2;
                reytar.TraverseSpeed = 24;
                reytar.amuletsMary = 445;
                reytar.sapphires = 0; // уточнить

                reytars[k] = reytar;
            }
            return reytars;
        }
        #endregion
        #region Жрица
        public BasicCavalry.Priestess[] CreatePriestess(int count)
        {
            BasicCavalry.Priestess[] priestesss = new BasicCavalry.Priestess[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Priestess priestess = new BasicCavalry.Priestess(new ConstructionTime() { Min = 54, Sec = 1 });

                priestess.Type = "Кавалерия";
                priestess.Name = "Жрица";
                priestess.Attack = 360;
                priestess.Infantry = 80;
                priestess.Cavalry = 80;
                priestess.Magistrate = 100;
                priestess.Bestiary = 100;
                priestess.Resources = 239;
                priestess.Meat = 2;
                priestess.TraverseSpeed = 25;
                priestess.amuletsMary = 940;
                priestess.sapphires = 0; // уточнить

                priestesss[k] = priestess;
            }
            return priestesss;
        }
        #endregion

        #region Имперская кочевница
        public BasicCavalry.ImperialNomad[] CreateImperialNomad(int count)
        {
            BasicCavalry.ImperialNomad[] imperialNomads = new BasicCavalry.ImperialNomad[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialNomad imperialNomad = new BasicCavalry.ImperialNomad(new ConstructionTime() { Min = 19, Sec = 1 });

                imperialNomad.Type = "Кавалерия";
                imperialNomad.Name = "Имперская кочевница";
                imperialNomad.Attack = 40;
                imperialNomad.Infantry = 130;
                imperialNomad.Cavalry = 170;
                imperialNomad.Magistrate = 170;
                imperialNomad.Bestiary = 130;
                imperialNomad.Resources = 117;
                imperialNomad.Meat = 2;
                imperialNomad.TraverseSpeed = 18;
                imperialNomad.gold = 264;
                imperialNomad.steel = 105;
                imperialNomad.meats = 159;
                imperialNomad.sapphires = 22;

                imperialNomads[k] = imperialNomad;

            }
            return imperialNomads;
        }
        #endregion
        #region Имперский рыцарь
        public BasicCavalry.ImperialKnight[] CreateImperialKnight(int count)
        {
            BasicCavalry.ImperialKnight[] imperialKnights = new BasicCavalry.ImperialKnight[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialKnight imperialKnight = new BasicCavalry.ImperialKnight(new ConstructionTime() { Min = 30, Sec = 1 });

                imperialKnight.Type = "Кавалерия";
                imperialKnight.Name = "Имперский рыцарь";
                imperialKnight.Attack = 240;
                imperialKnight.Infantry = 30;
                imperialKnight.Cavalry = 80;
                imperialKnight.Magistrate = 30;
                imperialKnight.Bestiary = 30;
                imperialKnight.Resources = 145;
                imperialKnight.Meat = 2;
                imperialKnight.TraverseSpeed = 18;
                imperialKnight.gold = 195;
                imperialKnight.steel = 324;
                imperialKnight.meats = 130;
                imperialKnight.sapphires = 34;

                imperialKnights[k] = imperialKnight;

            }
            return imperialKnights;
        }
        #endregion
        #region Имперский варвар
        public BasicCavalry.ImperialBarbarian[] CreateImperialBarbarian(int count)
        {
            BasicCavalry.ImperialBarbarian[] imperialBarbarians = new BasicCavalry.ImperialBarbarian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialBarbarian imperialBarbarian = new BasicCavalry.ImperialBarbarian(new ConstructionTime() { Min = 19, Sec = 1 });

                imperialBarbarian.Type = "Кавалерия";
                imperialBarbarian.Name = "Имперский варвар";
                imperialBarbarian.Attack = 50;
                imperialBarbarian.Infantry = 170;
                imperialBarbarian.Cavalry = 170;
                imperialBarbarian.Magistrate = 130;
                imperialBarbarian.Bestiary = 130;
                imperialBarbarian.Resources = 127;
                imperialBarbarian.Meat = 2;
                imperialBarbarian.TraverseSpeed = 12;
                imperialBarbarian.gold = 285;
                imperialBarbarian.steel = 171;
                imperialBarbarian.meats = 114;
                imperialBarbarian.sapphires = 22;

                imperialBarbarians[k] = imperialBarbarian;
            }
            return imperialBarbarians;
        }
        #endregion
        #region Имперский грандлорд
        public BasicCavalry.ImperialGrandlord[] CreateImperialGrandlord(int count)
        {
            BasicCavalry.ImperialGrandlord[] imperialGrandlords = new BasicCavalry.ImperialGrandlord[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialGrandlord imperialGrandlord = new BasicCavalry.ImperialGrandlord(new ConstructionTime() { Min = 45, Sec = 1 });

                imperialGrandlord.Type = "Кавалерия";
                imperialGrandlord.Name = "Имперский грандлорд";
                imperialGrandlord.Attack = 360;
                imperialGrandlord.Infantry = 80;
                imperialGrandlord.Cavalry = 30;
                imperialGrandlord.Magistrate = 30;
                imperialGrandlord.Bestiary = 30;
                imperialGrandlord.Resources = 239;
                imperialGrandlord.Meat = 2;
                imperialGrandlord.TraverseSpeed = 12;
                imperialGrandlord.gold = 216;
                imperialGrandlord.steel = 540;
                imperialGrandlord.meats = 300;
                imperialGrandlord.sapphires = 51;

                imperialGrandlords[k] = imperialGrandlord;
            }
            return imperialGrandlords;
        }
        #endregion
        #region Имперская наездница
        public BasicCavalry.ImperialEquestrian[] CreateImperialEquestrian(int count)
        {
            BasicCavalry.ImperialEquestrian[] imperialEquestrians = new BasicCavalry.ImperialEquestrian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialEquestrian imperialEquestrian = new BasicCavalry.ImperialEquestrian(new ConstructionTime() { Min = 45, Sec = 1 });

                imperialEquestrian.Type = "Кавалерия";
                imperialEquestrian.Name = "Имперская наездница";
                imperialEquestrian.Attack = 360;
                imperialEquestrian.Infantry = 30;
                imperialEquestrian.Cavalry = 40;
                imperialEquestrian.Magistrate = 40;
                imperialEquestrian.Bestiary = 40;
                imperialEquestrian.Resources = 250;
                imperialEquestrian.Meat = 2;
                imperialEquestrian.TraverseSpeed = 20;
                imperialEquestrian.gold = 400;
                imperialEquestrian.steel = 700;
                imperialEquestrian.meats = 700;
                imperialEquestrian.sapphires = 0; // уточнить

                imperialEquestrians[k] = imperialEquestrian;
            }
            return imperialEquestrians;
        }
        #endregion
        #region Имперский рейтар
        public BasicCavalry.ImperialReytar[] CreateImperialReytar(int count)
        {
            BasicCavalry.ImperialReytar[] imperialReytars = new BasicCavalry.ImperialReytar[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialReytar imperialReytar = new BasicCavalry.ImperialReytar(new ConstructionTime() { Min = 23, Sec = 1 });

                imperialReytar.Type = "Кавалерия";
                imperialReytar.Name = "Имперский рейтар";
                imperialReytar.Attack = 50;
                imperialReytar.Infantry = 150;
                imperialReytar.Cavalry = 150;
                imperialReytar.Magistrate = 150;
                imperialReytar.Bestiary = 150;
                imperialReytar.Resources = 117;
                imperialReytar.Meat = 2;
                imperialReytar.TraverseSpeed = 24;
                imperialReytar.amuletsMary = 147;
                imperialReytar.sapphires = 0; // уточнить

                imperialReytars[k] = imperialReytar;
            }
            return imperialReytars;
        }
        #endregion
        #region Имперская жрица
        public BasicCavalry.ImperialPriestess[] CreateImperialPriestess(int count)
        {
            BasicCavalry.ImperialPriestess[] imperialPriestesss = new BasicCavalry.ImperialPriestess[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.ImperialPriestess imperialPriestess = new BasicCavalry.ImperialPriestess(new ConstructionTime() { Min = 54, Sec = 1 });

                imperialPriestess.Type = "Кавалерия";
                imperialPriestess.Name = "Имперская жрица";
                imperialPriestess.Attack = 360;
                imperialPriestess.Infantry = 80;
                imperialPriestess.Cavalry = 80;
                imperialPriestess.Magistrate = 100;
                imperialPriestess.Bestiary = 100;
                imperialPriestess.Resources = 239;
                imperialPriestess.Meat = 2;
                imperialPriestess.TraverseSpeed = 25;
                imperialPriestess.amuletsMary = 310;
                imperialPriestess.sapphires = 0; // уточнить

                imperialPriestesss[k] = imperialPriestess;
            }
            return imperialPriestesss;
        }
        #endregion

        #region Темная Кочевница
        public BasicCavalry.DarkNomad[] CreateDarkNomad(int count)
        {
            BasicCavalry.DarkNomad[] darkNomads = new BasicCavalry.DarkNomad[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.DarkNomad darkNomad = new BasicCavalry.DarkNomad(new ConstructionTime() { Min = 0, Sec = 1 });

                darkNomad.Type = "Кавалерия";
                darkNomad.Name = "Темная Кочевница";
                darkNomad.Attack = 42;
                darkNomad.Infantry = 136;
                darkNomad.Cavalry = 178;
                darkNomad.Magistrate = 178;
                darkNomad.Bestiary = 136;
                darkNomad.Resources = 117;
                darkNomad.Meat = 1;
                darkNomad.TraverseSpeed = 18;
                darkNomad.sapphires = 22;

                darkNomads[k] = darkNomad;

            }
            return darkNomads;
        }
        #endregion
        #region Темный Рыцарь
        public BasicCavalry.DarkKnight[] CreateDarkKnight(int count)
        {
            BasicCavalry.DarkKnight[] darkKnights = new BasicCavalry.DarkKnight[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.DarkKnight darkKnight = new BasicCavalry.DarkKnight(new ConstructionTime() { Min = 0, Sec = 1 });

                darkKnight.Type = "Кавалерия";
                darkKnight.Name = "Темный Рыцарь";
                darkKnight.Attack = 252;
                darkKnight.Infantry = 32;
                darkKnight.Cavalry = 84;
                darkKnight.Magistrate = 32;
                darkKnight.Bestiary = 32;
                darkKnight.Resources = 145;
                darkKnight.Meat = 1;
                darkKnight.TraverseSpeed = 18;
                darkKnight.sapphires = 34;

                darkKnights[k] = darkKnight;

            }
            return darkKnights;
        }
        #endregion
        #region Темный Варвар
        public BasicCavalry.DarkBarbarian[] CreateDarkBarbarian(int count)
        {
            BasicCavalry.DarkBarbarian[] darkBarbarians = new BasicCavalry.DarkBarbarian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.DarkBarbarian darkBarbarian = new BasicCavalry.DarkBarbarian(new ConstructionTime() { Min = 0, Sec = 1 });

                darkBarbarian.Type = "Кавалерия";
                darkBarbarian.Name = "Темный Варвар";
                darkBarbarian.Attack = 52;
                darkBarbarian.Infantry = 178;
                darkBarbarian.Cavalry = 178;
                darkBarbarian.Magistrate = 136;
                darkBarbarian.Bestiary = 136;
                darkBarbarian.Resources = 127;
                darkBarbarian.Meat = 1;
                darkBarbarian.TraverseSpeed = 12;
                darkBarbarian.sapphires = 22;

                darkBarbarians[k] = darkBarbarian;

            }
            return darkBarbarians;
        }
        #endregion
        #region Темный Грандлорд
        public BasicCavalry.DarkGrandlord[] CreateDarkGrandlord(int count)
        {
            BasicCavalry.DarkGrandlord[] darkGrandlords = new BasicCavalry.DarkGrandlord[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.DarkGrandlord darkGrandlord = new BasicCavalry.DarkGrandlord(new ConstructionTime() { Min = 0, Sec = 1 });

                darkGrandlord.Type = "Кавалерия";
                darkGrandlord.Name = "Темный Грандлорд";
                darkGrandlord.Attack = 378;
                darkGrandlord.Infantry = 84;
                darkGrandlord.Cavalry = 32;
                darkGrandlord.Magistrate = 32;
                darkGrandlord.Bestiary = 32;
                darkGrandlord.Resources = 239;
                darkGrandlord.Meat = 1;
                darkGrandlord.TraverseSpeed = 12;
                darkGrandlord.sapphires = 51;

                darkGrandlords[k] = darkGrandlord;

            }
            return darkGrandlords;
        }
        #endregion
        #region Темная Наездница
        public BasicCavalry.DarkEquestrian[] CreateDarkEquestrian(int count)
        {
            BasicCavalry.DarkEquestrian[] darkEquestrians = new BasicCavalry.DarkEquestrian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.DarkEquestrian darkEquestrian = new BasicCavalry.DarkEquestrian(new ConstructionTime() { Min = 0, Sec = 1 });

                darkEquestrian.Type = "Кавалерия";
                darkEquestrian.Name = "Темная Наездница";
                darkEquestrian.Attack = 378;
                darkEquestrian.Infantry = 32;
                darkEquestrian.Cavalry = 42;
                darkEquestrian.Magistrate = 42;
                darkEquestrian.Bestiary = 42;
                darkEquestrian.Resources = 250;
                darkEquestrian.Meat = 1;
                darkEquestrian.TraverseSpeed = 25;
                darkEquestrian.sapphires = 0; // уточнить

                darkEquestrians[k] = darkEquestrian;

            }
            return darkEquestrians;
        }
        #endregion

        #region Возрожденный рыцарь
        public BasicCavalry.RevivedKnight[] CreateRevivedKnight(int count)
        {
            BasicCavalry.RevivedKnight[] revivedKnights = new BasicCavalry.RevivedKnight[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.RevivedKnight revivedKnight = new BasicCavalry.RevivedKnight(new ConstructionTime() { Min = 0, Sec = 1 });

                revivedKnight.Type = "Кавалерия";
                revivedKnight.Name = "Возрожденный рыцарь";
                revivedKnight.Attack = 250;
                revivedKnight.Infantry = 40;
                revivedKnight.Cavalry = 50;
                revivedKnight.Magistrate = 40;
                revivedKnight.Bestiary = 40;
                revivedKnight.Resources = 150;
                revivedKnight.Meat = 1;
                revivedKnight.TraverseSpeed = 18;
                revivedKnight.sapphires = 34; // уточнить

                revivedKnights[k] = revivedKnight;

            }
            return revivedKnights;
        }
        #endregion
        #region Возрожденный варвар
        public BasicCavalry.RevivedBarbarian[] CreateRevivedBarbarian(int count)
        {
            BasicCavalry.RevivedBarbarian[] revivedBarbarians = new BasicCavalry.RevivedBarbarian[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.RevivedBarbarian revivedBarbarian = new BasicCavalry.RevivedBarbarian(new ConstructionTime() { Min = 0, Sec = 1 });

                revivedBarbarian.Type = "Кавалерия";
                revivedBarbarian.Name = "Возрожденный варвар";
                revivedBarbarian.Attack = 250;
                revivedBarbarian.Infantry = 40;
                revivedBarbarian.Cavalry = 50;
                revivedBarbarian.Magistrate = 40;
                revivedBarbarian.Bestiary = 40;
                revivedBarbarian.Resources = 150;
                revivedBarbarian.Meat = 1;
                revivedBarbarian.TraverseSpeed = 18;
                revivedBarbarian.sapphires = 34; // уточнить

                revivedBarbarians[k] = revivedBarbarian;

            }
            return revivedBarbarians;
        }
        #endregion

        #region Рейдер
        public BasicCavalry.Raider[] CreateRaider(int count)
        {
            BasicCavalry.Raider[] raiders = new BasicCavalry.Raider[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Raider raider = new BasicCavalry.Raider(new ConstructionTime() { Min = 0, Sec = 1 });

                raider.Type = "Кавалерия";
                raider.Name = "Рейдер";
                raider.Attack = 40;
                raider.Infantry = 40;
                raider.Cavalry = 120;
                raider.Magistrate = 40;
                raider.Bestiary = 40;
                raider.Resources = 80;

                raiders[k] = raider;

            }
            return raiders;
        }
        #endregion

        #region Пегас
        public BasicCavalry.Pegasus[] CreatePegasus(int count)
        {
            BasicCavalry.Pegasus[] pegasuss = new BasicCavalry.Pegasus[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Pegasus pegasus = new BasicCavalry.Pegasus(new ConstructionTime() { Min = 0, Sec = 1 });

                pegasus.Type = "Кавалерия";
                pegasus.Name = "Пегас";
                pegasus.Attack = 1008;
                pegasus.Infantry = 224;
                pegasus.Cavalry = 84;
                pegasus.Magistrate = 84;
                pegasus.Bestiary = 84;
                pegasus.Resources = 1000;
                pegasus.Meat = 4;
                pegasus.TraverseSpeed = 27;
                pegasus.sapphires = 518;

                pegasuss[k] = pegasus;

            }
            return pegasuss;
        }
        #endregion
        #region Элефант
        public BasicCavalry.Elephant[] CreateElephant(int count)
        {
            BasicCavalry.Elephant[] elephants = new BasicCavalry.Elephant[count];

            for (int k = 0; k < count; k++)
            {
                BasicCavalry.Elephant elephant = new BasicCavalry.Elephant(new ConstructionTime() { Min = 0, Sec = 1 });

                elephant.Type = "Кавалерия";
                elephant.Name = "Элефант";
                elephant.Attack = 210;
                elephant.Infantry = 714;
                elephant.Cavalry = 714;
                elephant.Magistrate = 546;
                elephant.Bestiary = 546;
                elephant.Resources = 1000;
                elephant.Meat = 2;
                elephant.TraverseSpeed = 27;
                elephant.sapphires = 255;

                elephants[k] = elephant;

            }
            return elephants;
        }
        #endregion
        #endregion

        #region Магистрат
        #region Крушитель

        #endregion

        #region Голем

        #endregion

        #region Чернокнижник

        #endregion

        #region Демон

        #endregion

        #region Некромант

        #endregion

        #region Ренегат

        #endregion

        #region Имперский голем



        #endregion

        #region Имперский чернокнижник

        #endregion

        #region Имперский демон

        #endregion

        #region Имперский некромант

        #endregion

        #region Имперский ренегат

        #endregion


        #endregion

        #region Бестиария



        #endregion

    }
}
