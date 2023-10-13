using System;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Trip
{
    public Trip(Route route)
    {
        Route = route;
    }

    public Collection<Result> SuccessfulResults { get; private set; } = new Collection<Result>();
    private Route Route { get; init; }

    public Result TryShip(ShipBase ship)
    {
        if (ship is null)
        {
            throw new ArgumentNullException(nameof(ship));
        }

        int cost = CalculateCost(ship);

        foreach (EnvironmentBase environment in Route.RouteParts)
        {
            if (environment is Space)
            {
                if (ship.HasImpulseEngine())
                {
                    if (environment.Asteroids is not null)
                    {
                        ship.TakeDamage(environment.Asteroids);
                    }

                    if (environment.Meteorites is not null)
                    {
                        ship.TakeDamage(environment.Meteorites);
                    }
                }
                else
                {
                    return new Result(ship.ShipName, false, cost);
                }
            }

            if (environment is HighDensityNebula)
            {
                if (environment.PathLength > ship.EngineRange())
                {
                    return new Result(ship.ShipName, false, cost);
                }

                if (ship.HasJumpingEngine())
                {
                    if (environment.Flares is not null)
                    {
                        ship.TakeDamage(environment.Flares);
                    }
                }
                else
                {
                    return new Result(ship.ShipName, false, cost);
                }
            }

            if (environment is NitrineNebula)
            {
                if (ship.HasEClassEngine())
                {
                    if (environment.SpaceWhales is not null)
                    {
                        ship.TakeDamage(environment.SpaceWhales);
                    }
                }
                else
                {
                    return new Result(ship.ShipName, false, cost);
                }
            }
        }

        SuccessfulResults.Add(new Result(ship.ShipName, ship.IsAlive, cost));

        return new Result(ship.ShipName, ship.IsAlive, cost);
    }

    public string? CompareResults()
    {
        Result? bestResult = null;
        foreach (Result result in SuccessfulResults)
        {
            if (!result.TripIsSuccessful)
            {
                continue;
            }

            if (bestResult is null || result.Cost < bestResult.Cost)
            {
                bestResult = result;
            }
        }

        if (bestResult is null)
        {
            return null;
        }

        return bestResult.Name;
    }

    private static int CalculateCost(ShipBase ship)
    {
        int fuelAmount = ship.FirstEngine.FuelConsumption + ship.SecondEngine.FuelConsumption;
        return FuelExchange.Exchange(fuelAmount);
    }
}