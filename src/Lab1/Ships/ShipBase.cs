using System;
using Itmo.ObjectOrientedProgramming.Lab1.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.JumpingEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class ShipBase
{
    public ShipBase(EngineBase firstEngine, EngineBase secondEngine, DeflectorBase deflector, ArmorBase armor)
    {
        if (firstEngine is null)
        {
            throw new ArgumentNullException(nameof(firstEngine));
        }

        if (secondEngine is null)
        {
            throw new ArgumentNullException(nameof(secondEngine));
        }

        if (deflector is null)
        {
            throw new ArgumentNullException(nameof(deflector));
        }

        if (armor is null)
        {
            throw new ArgumentNullException(nameof(armor));
        }

        ShipName = "JustSomeShip";
        IsAlive = true;
        FirstEngine = firstEngine;
        SecondEngine = secondEngine;
        Deflector = deflector;
        Armor = armor;
    }

    public string ShipName { get; init; }
    public EngineBase FirstEngine { get; init; }
    public EngineBase SecondEngine { get; init; }

    public DeflectorBase Deflector { get; init; }

    public ArmorBase Armor { get; init; }

    public bool IsAlive { get; private set; }

    public void AddPhotonMod()
    {
        Deflector.AddPhotonMod();
    }

    public void AddAntiNitrineMod()
    {
        Deflector.AddAntiNitrineMod();
    }

    public void TakeDamage(ObstacleBase obstacle)
    {
        Deflector.TakeDamage(obstacle);
        Armor.TakeDamage(obstacle);

        if (obstacle.IsExist())
        {
            IsAlive = false;
        }
    }

    public bool HasImpulseEngine()
    {
        if (FirstEngine is ImpulseEngineBase |
            SecondEngine is ImpulseEngineBase)
        {
            return true;
        }

        return false;
    }

    public bool HasJumpingEngine()
    {
        if (FirstEngine is JumpingEngineBase |
            SecondEngine is JumpingEngineBase)
        {
            return true;
        }

        return false;
    }

    public int EngineRange()
    {
        int range = FirstEngine.Range;
        range = int.Max(range, SecondEngine.Range);
        return range;
    }

    public bool HasEClassEngine()
    {
        if (FirstEngine is EClassEngine |
            SecondEngine is EClassEngine)
        {
            return true;
        }

        return false;
    }
}