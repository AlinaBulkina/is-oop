using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpu;

public class Cpu
{
    public Cpu(
        string? name,
        int frequency,
        int coresNumber,
        string? socket,
        bool videoCore,
        int supportedMemoryFrequencies,
        int tdp,
        int powerConsumption)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (frequency <= 0) throw new ArgumentOutOfRangeException(nameof(frequency));

        if (coresNumber <= 0) throw new ArgumentOutOfRangeException(nameof(coresNumber));

        if (string.IsNullOrWhiteSpace(socket)) throw new ArgumentNullException(nameof(socket));

        if (supportedMemoryFrequencies <= 0) throw new ArgumentOutOfRangeException(nameof(supportedMemoryFrequencies));

        if (tdp <= 0) throw new ArgumentOutOfRangeException(nameof(tdp));

        if (powerConsumption <= 0) throw new ArgumentOutOfRangeException(nameof(powerConsumption));

        Name = name;
        Frequency = frequency;
        CoresNumber = coresNumber;
        Socket = socket;
        VideoCore = videoCore;
        SupportedMemoryFrequencies = supportedMemoryFrequencies;
        Tdp = tdp;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }

    public int Frequency { get; }
    public int CoresNumber { get; }
    public string Socket { get; }
    public bool VideoCore { get; }
    public int SupportedMemoryFrequencies { get; }
    public int Tdp { get; }

    public int PowerConsumption { get; }

    public Cpu Clone()
    {
        return new Cpu(
            Name,
            Frequency,
            CoresNumber,
            Socket,
            VideoCore,
            SupportedMemoryFrequencies,
            Tdp,
            PowerConsumption);
    }
}