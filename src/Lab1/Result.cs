using Itmo.ObjectOrientedProgramming.Lab1.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Result
{
    public Result(ShipBase ship, bool result, int cost)
    {
        Ship = ship;
        TripIsSuccessful = result;
        Cost = cost;
    }

    public ShipBase Ship { get; init; }
    public bool TripIsSuccessful { get; init; }
    public int Cost { get; init; }
}