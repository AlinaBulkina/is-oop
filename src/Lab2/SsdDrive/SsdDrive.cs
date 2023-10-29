using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;

public class SsdDrive
{
    public SsdDrive(string? name, string? connection, int capacity, int operatingSpeed, int powerConsumption)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (string.IsNullOrEmpty(connection)) throw new ArgumentNullException(nameof(connection));

        if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));

        if (operatingSpeed <= 0) throw new ArgumentOutOfRangeException(nameof(operatingSpeed));

        if (powerConsumption <= 0) throw new ArgumentOutOfRangeException(nameof(powerConsumption));

        Name = name;
        Connection = connection;
        Capacity = capacity;
        OperatingSpeed = operatingSpeed;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public string Connection { get; }
    public int Capacity { get; }
    public int OperatingSpeed { get; }
    public int PowerConsumption { get; }

    public SsdDrive Clone()
    {
        return new SsdDrive(Name, Connection, Capacity, OperatingSpeed, PowerConsumption);
    }
}