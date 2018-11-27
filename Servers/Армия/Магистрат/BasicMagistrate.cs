using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Класс определяет,является юнит атакующим,или защитником для Магистрата
/// </summary>

namespace Servers
{
    public abstract class BasicMagistrate : BasicWarrior
    {
        public BasicMagistrate(ConstructionTime constructionTime) : base(constructionTime) { }

        #region Крушитель
        public class Krushitel : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public Krushitel(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Голем
        public class Golem : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public Golem(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Чернокнижник
        public class Magician : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public Magician(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Демон
        public class Demon : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public Demon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Некромант
        public class Necromancer : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public Necromancer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Ренегат
        public class Renegade : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public Renegade(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский голем
        public class ImperialGolem : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public ImperialGolem(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский чернокнижник
        public class ImperialMagician : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public ImperialMagician(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский демон
        public class ImperialDemon : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public ImperialDemon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский некромант
        public class ImperialNecromancer : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public ImperialNecromancer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Имперский ренегат
        public class ImperialRenegade : BasicMagistrate
        {
            public override bool off { get; set; } = true;

            public ImperialRenegade(ConstructionTime constructionTime) : base(constructionTime) { }            
        }
        #endregion
        #region Темный Голем
        public class DarkGolem : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public DarkGolem(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Чернокнижник
        public class DarkMagician : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public DarkMagician(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Демон
        public class DarkDemon : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public DarkDemon(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Темный Некромант
        public class DarkNecromancer : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public DarkNecromancer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный Голем
        public class RevivedGolem : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public RevivedGolem(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Возрожденный Некромант
        public class RevivedNecromancer : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public RevivedNecromancer(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Людоед
        public class Cannibal : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public Cannibal(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Падший
        public class Fallen : BasicMagistrate
        {
            public override bool off { get; set; } = true;
            public Fallen(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
        #region Гидра
        public class Hydra : BasicMagistrate
        {
            public override bool off { get; set; } = false;
            public Hydra(ConstructionTime constructionTime) : base(constructionTime) { }
        }
        #endregion
    }
}
