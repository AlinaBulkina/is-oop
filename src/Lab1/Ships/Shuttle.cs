using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Shuttle : ShipBase
{
    public Shuttle()
        : base(
            new CClassEngine(),
            new NullEngine(),
            new NullDeflector(),
            new FirstClassArmor())
    {
        ShipName = "Shuttle";
    }
}