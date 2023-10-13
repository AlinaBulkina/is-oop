using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.JumpingEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Avgur : ShipBase
{
    public Avgur()
        : base(
            new EClassEngine(),
            new AlphaJumpingEngine(),
            new ThirdClassDeflector(),
            new ThirdClassArmor())
    {
        ShipName = "Avgur";
    }
}