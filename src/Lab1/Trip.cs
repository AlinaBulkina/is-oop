using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Trip
{
    public Trip(Route route)
    {
        Route = route;
    }

    private Route Route { get; init; }

    public Result TryShip(ShipBase ship)
    {
        if (ship == null)
        {
            throw new ArgumentNullException(nameof(ship));
        }

        int cost = CalculateCost(ship);

        foreach (EnvironmentBase environment in Route.RouteParts)
        {
            if (environment.GetType() == typeof(Space))
            {
                if (ship.HasImpulseEngine())
                {
                    var asteroids = new Asteroid(environment.AsteroidCount);
                    var meteorites = new Meteorite(environment.MeteoriteCount);

                    ship.TakeDamage(asteroids);
                    ship.TakeDamage(meteorites);
                }
                else
                {
                    return new Result(false, cost);
                }
            }

            if (environment.GetType() == typeof(HighDensityNebula))
            {
                if (ship.HasJumpingEngine())
                {
                    var flare = new Flare(environment.FlareCount);
                    ship.TakeDamage(flare);
                }
                else
                {
                    return new Result(false, cost);
                }
            }

            if (environment.GetType() == typeof(NitrineNebula))
            {
                if (ship.HasEClassEngine())
                {
                    var spaceWhales = new SpaceWhale(environment.SpaceWhaleCount);
                    ship.TakeDamage(spaceWhales);
                }
                else
                {
                    return new Result(false, cost);
                }
            }
        }

        return new Result(ship.IsAlive, cost);
    }

    private static int CalculateCost(ShipBase ship)
    {
        int fuelAmount = ship.FirstEngine.FuelConsumption + ship.SecondEngine.FuelConsumption;
        return FuelExchange.Exchange(fuelAmount);
    }
}