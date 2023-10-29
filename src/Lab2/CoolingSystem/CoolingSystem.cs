using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;

public class CoolingSystem
{
    public CoolingSystem(string? name, int size, string? socket, int tdp)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (size <= 0) throw new ArgumentOutOfRangeException(nameof(size));

        if (string.IsNullOrWhiteSpace(socket)) throw new ArgumentNullException(nameof(socket));

        if (tdp <= 0) throw new ArgumentOutOfRangeException(nameof(tdp));

        Name = name;
        Size = size;
        Socket = socket;
        Tdp = tdp;
    }

    public string Name { get; }
    public int Size { get; }
    public string Socket { get; }
    public int Tdp { get; }

    public CoolingSystem Clone()
    {
        return new CoolingSystem(Name, Size, Socket, Tdp);
    }
}