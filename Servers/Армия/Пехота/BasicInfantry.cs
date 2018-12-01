using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Класс определяет,является юнит атакующим,или защитником для Пехоты
/// </summary>

namespace Servers
{
    public abstract class BasicInfantry : BasicWarrior
    {
        public BasicInfantry(ConstructionTime constructionTime) : base(constructionTime) { }

        #region Нежить
        public class Indulge : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Indulge(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Копейщик
        public class Kopeyshchik : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Kopeyshchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Лучница
        public class Archeress : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Archeress(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Гном
        public class Gnome : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Gnome(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        #endregion
        #region Паладин
        public class Paladin : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Paladin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Арбалетчик
        public class Arbaletchik : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Arbaletchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Всадник
        public class Rider : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Rider(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Патриарх
        public class Patriarch : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Patriarch(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Баллиста
        public class Ballista : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Ballista(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Следопыт
        public class Pathfinder : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Pathfinder(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Охотница
        public class Hunter : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Hunter(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Вирсаав
        public class Virsaav : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Virsaav(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Изгой
        public class Derelict : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Derelict(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский копейщик
        public class ImperialKopeyshchik : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public ImperialKopeyshchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская лучница
        public class ImperialArcheress : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialArcheress(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский гном
        public class ImperialGnome : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialGnome(ConstructionTime constructionTime) : base(constructionTime) { }
        }



        #endregion
        #region Имперский паладин
        public class ImperialPaladin : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public ImperialPaladin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский арбалетчик
        public class ImperialArbaletchik : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialArbaletchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский всадник
        public class ImperialRider : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialRider(ConstructionTime constructionTime) : base(constructionTime) { }
        }


        #endregion
        #region Имперский патриарх
        public class ImperialPatriarch : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialPatriarch(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская баллиста
        public class ImperialBallista : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialBallista(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский следопыт
        public class ImperialPathfinder : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public ImperialPathfinder(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская охотница
        public class ImperialHunter : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialHunter(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский Вирсаав
        public class ImperialVirsaav : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public ImperialVirsaav(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский изгой
        public class ImperialDerelict : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public ImperialDerelict(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Копейщик
        public class DarkKopeyshchik : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public DarkKopeyshchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Лучница
        public class DarkArcheress : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkArcheress(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Гном
        public class DarkGnome : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkGnome(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Паладин
        public class DarkPaladin : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public DarkPaladin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Арбалетчик
        public class DarkArbaletchik : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkArbaletchik(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Всадник
        public class DarkRider : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkRider(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Патриарх
        public class DarkPatriarch : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkPatriarch(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Баллиста
        public class DarkBallista : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkBallista(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Следопыт
        public class DarkPathfinder : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public DarkPathfinder(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Охотница
        public class DarkHunter : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public DarkHunter(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Орк
        public class Ork : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Ork(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Герой
        public class Hero : BasicInfantry
        {
            public override bool off { get; set; } = true;
            public Hero(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Нейт
        public class Nate : BasicInfantry
        {
            public override bool off { get; set; } = false;
            public Nate(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion

    }
}
