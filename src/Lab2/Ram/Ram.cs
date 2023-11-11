using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ram;

public class Ram
{
    public Ram(
        string? name,
        int availableMemory,
        int jedec,
        bool xmp,
        string? formFactor,
        int ddr,
        int powerConsumption)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (availableMemory <= 0) throw new ArgumentOutOfRangeException(nameof(availableMemory));

        if (jedec <= 0) throw new ArgumentOutOfRangeException(nameof(jedec));

        if (string.IsNullOrWhiteSpace(formFactor)) throw new ArgumentNullException(nameof(formFactor));

        if (ddr <= 0) throw new ArgumentOutOfRangeException(nameof(ddr));

        if (powerConsumption <= 0) throw new ArgumentOutOfRangeException(nameof(powerConsumption));

        Name = name;
        AvailableMemory = availableMemory;
        Jedec = jedec;
        Xmp = xmp;
        FormFactor = formFactor;
        Ddr = ddr;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public int AvailableMemory { get; }
    public int Jedec { get; }
    public bool Xmp { get; }
    public string FormFactor { get; }
    public int Ddr { get; }
    public int PowerConsumption { get; }

    public Ram Clone()
    {
        return new Ram(Name, AvailableMemory, Jedec, Xmp, FormFactor, Ddr, PowerConsumption);
    }
}