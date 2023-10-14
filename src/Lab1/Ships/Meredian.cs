using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.ImpulseEngines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Meredian : ShipBase
{
    public Meredian()
        : base(
            new EClassEngine(),
            new NullEngine(),
            new SecondClassDeflector(),
            new SecondClassArmor())
    {
        ShipName = "Meredian";
        Deflector.AddAntiNitrineMod();
    }
}