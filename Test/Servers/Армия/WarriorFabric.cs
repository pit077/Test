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



        #endregion
        #endregion

        #region Кавалерия



        #endregion

        #region Магистрат



        #endregion

        #region Бестиария



        #endregion

    }
}
