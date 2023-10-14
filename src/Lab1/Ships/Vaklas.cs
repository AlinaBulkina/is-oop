using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.JumpingEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Vaklas : ShipBase
{
    public Vaklas()
        : base(
            new EClassEngine(),
            new GammaJumpingEngine(),
            new FirstClassDeflector(),
            new SecondClassArmor())
    {
        ShipName = "Vaklas";
    }
}