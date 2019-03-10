using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public abstract class BasicRelicOF : BasicRelics
    {
        public BasicRelicOF(ConstructionTime constructionTime) : base(constructionTime) { }

        public class AngerDrop : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public AngerDrop(ConstructionTime constructionTime) : base(constructionTime) { }

        }

        public class SignRage : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public SignRage(ConstructionTime constructionTime) : base(constructionTime) { }
        }


        public class ForceDrink : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public ForceDrink(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BarbarianHelmet : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BarbarianHelmet(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class IncentiveStaff : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public IncentiveStaff(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BerserkaMask : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BerserkaMask(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ElfinSpear : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public ElfinSpear(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class Fleecer : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public Fleecer(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class TearsEyre : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public TearsEyre(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class MarchingSmithy : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public MarchingSmithy(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class CaptainHorn : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public CaptainHorn(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class AntGod : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public AntGod(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class IronWreath : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public IronWreath(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class VeyonBanner : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public VeyonBanner(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class GoldAquila : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public GoldAquila(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class RahnStandard : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public RahnStandard(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class EldurFlame : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public EldurFlame(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class HeavyHarness : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public HeavyHarness(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BurnPotion : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BurnPotion(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BootsDead : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BootsDead(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ElChernotopya : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public ElChernotopya(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class HorrorMask : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public HorrorMask(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class NefilimWing : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public NefilimWing(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LevaynThorn : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public LevaynThorn(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ChronosEdge : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public ChronosEdge(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class PozhinatelBuri : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public PozhinatelBuri(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class VeyonArrows : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public VeyonArrows(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class HoneyPotion : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public HoneyPotion(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class UlrichSword : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public UlrichSword(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class SignFirmness : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public SignFirmness(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LovarEye : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public LovarEye(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BranHand : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BranHand(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BranWings : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BranWings(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BloodNight : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BloodNight(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class Morte : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public Morte(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class ArrowsGiven : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public ArrowsGiven(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BottomlessBag : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BottomlessBag(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class MobilizationPlan : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public MobilizationPlan(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class RevengeWings : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public RevengeWings(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class BlackSun : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public BlackSun(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class SteelBeak : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public SteelBeak(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class LovarClaw : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public LovarClaw(ConstructionTime constructionTime) : base(constructionTime) { }
        }

        public class PoisonousClaw : BasicRelicOF
        {
            public override bool RelicOn { get; set; } = true;
            public PoisonousClaw(ConstructionTime constructionTime) : base(constructionTime) { }
        }

    }
}
