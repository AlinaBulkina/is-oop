namespace Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;

public class SsdDrive
{
    public SsdDrive(string name, string connection, int capacity, int operatingSpeed, int powerConsumption)
    {
        Name = name;
        Connection = connection;
        Capacity = capacity;
        OperatingSpeed = operatingSpeed;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public string Connection { get; init; }
    public int Capacity { get; init; }
    public int OperatingSpeed { get; init; }
    public int PowerConsumption { get; init; }

    public SsdDrive Clone()
    {
        return new SsdDrive(Name, Connection, Capacity, OperatingSpeed, PowerConsumption);
    }
}