using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Класс определяет,является юнит атакующим,или защитником для Кавалерии
/// </summary>

namespace Servers
{
    public abstract class BasicCavalry : BasicWarrior
    {
        public BasicCavalry(ConstructionTime constructionTime) : base(constructionTime) { }

        #region Кочевница
        public class Nomad : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public Nomad(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Рыцарь
        public class Knight : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public Knight(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Варвар
        public class Barbarian : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public Barbarian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Грандлорд
        public class Grandlord : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public Grandlord(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Наездница
        public class Equestrian : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public Equestrian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Рейтар
        public class Reytar : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public Reytar(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Жрица
        public class Priestess : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public Priestess(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская кочевница
        public class ImperialNomad : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public ImperialNomad(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский рыцарь
        public class ImperialKnight : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public ImperialKnight(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский варвар
        public class ImperialBarbarian : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public ImperialBarbarian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский грандлорд
        public class ImperialGrandlord : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public ImperialGrandlord(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская наездница
        public class ImperialEquestrian : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public ImperialEquestrian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский рейтар
        public class ImperialReytar : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public ImperialReytar(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперская жрица
        public class ImperialPriestess : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public ImperialPriestess(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Кочевница
        public class DarkNomad : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public DarkNomad(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Рыцарь
        public class DarkKnight : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public DarkKnight(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Варвар
        public class DarkBarbarian : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public DarkBarbarian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Грандлорд
        public class DarkGrandlord : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public DarkGrandlord(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темная Наездница
        public class DarkEquestrian : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public DarkEquestrian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный рыцарь
        public class RevivedKnight : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public RevivedKnight(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный варвар
        public class RevivedBarbarian : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public RevivedBarbarian(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Рейдер
        public class Raider : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public Raider(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Пегас
        public class Pegasus : BasicCavalry
        {
            public override bool off { get; set; } = true;
            public Pegasus(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Элефант
        public class Elephant : BasicCavalry
        {
            public override bool off { get; set; } = false;
            public Elephant(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
    }
}
