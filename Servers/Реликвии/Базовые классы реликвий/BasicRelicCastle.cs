using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public abstract class BasicRelicCastle : BasicRelics
    {
        public BasicRelicCastle(ConstructionTime constructionTime) : base(constructionTime) { }

        public class SteelmakerPincers : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public SteelmakerPincers(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BranFoundry : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public BranFoundry(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LeprekonaHat : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public LeprekonaHat(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class CirceStekhanov : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public CirceStekhanov(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ButcherAxe : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public ButcherAxe(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LovaraSpices : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public LovaraSpices(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class SpiritSoy : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public SpiritSoy(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LovarPot : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public LovarPot(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class MerlinAbstracts : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public MerlinAbstracts(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class IronMaiden : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public IronMaiden(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ProtectionGods : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public ProtectionGods(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class HeldNetwork : BasicRelicCastle
        {
            public override bool RelicOn { get; set; } = true;
            public HeldNetwork(ConstructionTime constructionTime) : base(constructionTime) { }
        }
    }
}
