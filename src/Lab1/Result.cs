namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Result
{
    public Result(string name, bool result, int cost)
    {
        Name = name;
        TripIsSuccessful = result;
        Cost = cost;
    }

    public string Name { get; init; }
    public bool TripIsSuccessful { get; init; }
    public int Cost { get; init; }
}