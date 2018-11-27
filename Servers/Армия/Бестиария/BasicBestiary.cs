using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Класс определяет,является юнит атакующим,или защитником для Бестиарии
/// </summary>

namespace Servers
{
    public abstract class BasicBestiary : BasicWarrior
    {
        public BasicBestiary(ConstructionTime constructionTime) : base(constructionTime) { }

        #region Грифон
        public class Griffin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Griffin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Виверна
        public class Wyvern : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public Wyvern(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Дракон
        public class Dragon : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public Dragon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Химера
        public class Chimera : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public Chimera(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Пожиратель
        public class Devourer : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Devourer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Шпион
        public class Spy : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Spy(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Суккуб
        public class Sukkub : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Sukkub(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Ассасин
        public class Assasin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Assasin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Мародер
        public class Marauder : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public Marauder(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский грифон
        public class ImperialGriffin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public ImperialGriffin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская виверна
        public class ImperialWyvern : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public ImperialWyvern(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский дракон
        public class ImperialDragon : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public ImperialDragon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская химера
        public class ImperialChimera : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public ImperialChimera(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский Пожиратель
        public class ImperialDevourer : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public ImperialDevourer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский шпион
        public class ImperialSpy : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public ImperialSpy(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский суккуб
        public class ImperialSukkub : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public ImperialSukkub(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский ассасин
        public class ImperialAssasin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public ImperialAssasin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Грифон
        public class DarkGriffin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public DarkGriffin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Виверна
        public class DarkWyvern : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public DarkWyvern(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Дракон
        public class DarkDragon : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public DarkDragon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Химера
        public class DarkChimera : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public DarkChimera(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Пожиратель
        public class DarkDevourer : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public DarkDevourer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Шпион
        public class DarkSpy : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public DarkSpy(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Суккуб
        public class DarSukkub : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public DarSukkub(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Ассасин
        public class DarAssasin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public DarAssasin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный Грифон
        public class RevivedGriffin : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public RevivedGriffin(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный Дракон
        public class RevivedDragon : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public RevivedDragon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Кошмар
        public class Nightmare : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Nightmare(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Инферно
        public class Inferno : BasicBestiary
        {
            public override bool off { get; set; } = true;
            public Inferno(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Архангел
        public class Archangel : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Archangel(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Потрошитель
        public class Eviscerator : BasicBestiary
        {
            public override bool off { get; set; } = false;
            public Eviscerator(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
    }
}
