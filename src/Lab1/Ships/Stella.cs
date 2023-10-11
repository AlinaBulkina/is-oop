using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Stella : ShipBase
{
    public Stella()
        : base(
            new CClassEngine(),
            new JumpingEngineBase(),
            new FirstClassDeflector(),
            new FirstClassArmor())
    {
        ShipName = "Stella";
    }
}