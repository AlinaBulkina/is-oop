using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Vaklas : ShipBase
{
    public Vaklas()
        : base(
            new EClassEngine(),
            new JumpingEngineBase(),
            new FirstClassDeflector(),
            new SecondClassArmor())
    {
        ShipName = "Vaklas";
    }
}