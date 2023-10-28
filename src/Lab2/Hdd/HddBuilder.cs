using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Hdd;

public class HddBuilder
{
    private string? _name;
    private int _capacity;
    private int _rotatingSpeed;
    private int _powerConsumption;

    public HddBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public HddBuilder WithCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public HddBuilder WithOperatingSpeed(int rotatingSpeed)
    {
        _rotatingSpeed = rotatingSpeed;
        return this;
    }

    public HddBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public Hdd Build()
    {
        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name));
        }

        if (_capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_capacity));
        }

        if (_rotatingSpeed <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_rotatingSpeed));
        }

        if (_powerConsumption <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_powerConsumption));
        }

        return new Hdd(_name, _capacity, _rotatingSpeed, _powerConsumption);
    }
}