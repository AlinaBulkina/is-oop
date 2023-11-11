using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Motherboard;

public class Motherboard
{
    public Motherboard(string? name, string? socket, string? formFactor, string? bios)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (string.IsNullOrWhiteSpace(socket)) throw new ArgumentNullException(nameof(socket));

        if (string.IsNullOrWhiteSpace(formFactor)) throw new ArgumentNullException(nameof(formFactor));

        if (string.IsNullOrWhiteSpace(bios)) throw new ArgumentNullException(nameof(bios));

        Name = name;
        Socket = socket;
        FormFactor = formFactor;
        Bios = bios;
    }

    public string Name { get; }
    public string Socket { get; }
    public string FormFactor { get; }
    public string Bios { get; }

    public Motherboard Clone()
    {
        return new Motherboard(Name, Socket, FormFactor, Bios);
    }
}