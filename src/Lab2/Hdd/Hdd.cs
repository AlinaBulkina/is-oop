using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Hdd;

public class Hdd
{
    public Hdd(string? name, int capacity, int rotationSpeed, int powerConsumption)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));

        if (rotationSpeed <= 0) throw new ArgumentOutOfRangeException(nameof(rotationSpeed));

        if (powerConsumption <= 0) throw new ArgumentOutOfRangeException(nameof(powerConsumption));

        Name = name;
        Capacity = capacity;
        RotationSpeed = rotationSpeed;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public int Capacity { get; }
    public int RotationSpeed { get; }
    public int PowerConsumption { get; }

    public Hdd Clone()
    {
        return new Hdd(Name, Capacity, RotationSpeed, PowerConsumption);
    }
}