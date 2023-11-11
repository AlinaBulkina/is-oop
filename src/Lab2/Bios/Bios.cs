using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios;

public class Bios
{
    private readonly ICollection<string> _validBiosNames = new List<string>
        { "BIOS", "UEFI", "AWARD", "AMI", "Phoenix" };

    public Bios(string? name, string? availableCpu)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
        if (_validBiosNames.Contains(name)) throw new ArgumentException("Wrong Bios name");

        Name = name;
        AvailableCpu = availableCpu ?? throw new ArgumentNullException(nameof(availableCpu));
    }

    public string Name { get; }
    public string AvailableCpu { get; }

    public Bios Clone()
    {
        return new Bios(Name, AvailableCpu);
    }
}