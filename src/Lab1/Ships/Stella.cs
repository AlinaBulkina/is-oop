using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.JumpingEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Stella : ShipBase
{
    public Stella()
        : base(
            new CClassEngine(),
            new OmegaJumpingEngine(),
            new FirstClassDeflector(),
            new FirstClassArmor())
    {
        ShipName = "Stella";
    }
}