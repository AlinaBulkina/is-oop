using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;

public class CoolingSystemBuilder
{
    private string? _name;
    private int _size;
    private string? _socket;
    private int _tdp;

    public CoolingSystemBuilder WithName(string name)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        return this;
    }

    public CoolingSystemBuilder WithSize(int size)
    {
        _size = size;
        return this;
    }

    public CoolingSystemBuilder WithSocket(string socket)
    {
        _socket = socket ?? throw new ArgumentNullException(nameof(socket));
        return this;
    }

    public CoolingSystemBuilder WithTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public CoolingSystem Build()
    {
        return new CoolingSystem(_name, _size, _socket, _tdp);
    }
}