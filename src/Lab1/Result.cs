namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Result
{
    public Result(bool result, int cost)
    {
        TripIsSuccessful = result;
        Cost = cost;
    }

    public bool TripIsSuccessful { get; init; }
    public int Cost { get; init; }
}