using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;

public class SsdDriveBuilder
{
    private string? _name;
    private string? _connection;
    private int _capacity;
    private int _operatingSpeed;
    private int _powerConsumption;

    public SsdDriveBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public SsdDriveBuilder WithConnection(string connection)
    {
        _connection = connection;
        return this;
    }

    public SsdDriveBuilder WithCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public SsdDriveBuilder WithOperatingSpeed(int operatingSpeed)
    {
        _operatingSpeed = operatingSpeed;
        return this;
    }

    public SsdDriveBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public SsdDrive Build()
    {
        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name));
        }

        if (_connection is null)
        {
            throw new ArgumentNullException(nameof(_connection));
        }

        if (_capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_capacity));
        }

        if (_operatingSpeed <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_operatingSpeed));
        }

        if (_powerConsumption <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_powerConsumption));
        }

        return new SsdDrive(_name, _connection, _capacity, _operatingSpeed, _powerConsumption);
    }
}