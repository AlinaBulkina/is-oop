namespace Itmo.ObjectOrientedProgramming.Lab2.Hdd;

public class Hdd
{
    public Hdd(string name, int capacity, int rotationSpeed, int powerConsumption)
    {
        Name = name;
        Capacity = capacity;
        RotationSpeed = rotationSpeed;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public int Capacity { get; init; }
    public int RotationSpeed { get; init; }
    public int PowerConsumption { get; init; }

    public Hdd Clone()
    {
        return new Hdd(Name, Capacity, RotationSpeed, PowerConsumption);
    }
}