using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer;

public class Computer
{
    public Computer(
        string? name,
        Motherboard.Motherboard? motherboard,
        Cpu.Cpu? cpu,
        Bios.Bios? bios,
        CoolingSystem.CoolingSystem? coolingSystem,
        Ram.Ram? ram,
        VideoCard.VideoCard? videoCard,
        SsdDrive.SsdDrive? ssdDrive,
        Hdd.Hdd? hdd,
        Frame.Frame? frame,
        ICollection<string> comments,
        bool computerIsValid)
    {
        Name = name;
        Motherboard = motherboard;
        Cpu = cpu;
        Bios = bios;
        CoolingSystem = coolingSystem;
        Ram = ram;
        VideoCard = videoCard;
        SsdDrive = ssdDrive;
        Hdd = hdd;
        Frame = frame;
        Comments = comments;
        ComputerIsValid = computerIsValid;
    }

    public string? Name { get; init; }
    public Motherboard.Motherboard? Motherboard { get; init; }
    public Cpu.Cpu? Cpu { get; init; }
    public Bios.Bios? Bios { get; init; }
    public CoolingSystem.CoolingSystem? CoolingSystem { get; init; }
    public Ram.Ram? Ram { get; init; }
    public VideoCard.VideoCard? VideoCard { get; init; }
    public SsdDrive.SsdDrive? SsdDrive { get; init; }
    public Hdd.Hdd? Hdd { get; init; }
    public Frame.Frame? Frame { get; init; }
    public ICollection<string> Comments { get; init; }
    public bool ComputerIsValid { get; init; }

    public Computer Clone()
    {
        return new Computer(
            Name,
            Motherboard,
            Cpu,
            Bios,
            CoolingSystem,
            Ram,
            VideoCard,
            SsdDrive,
            Hdd,
            Frame,
            Comments,
            ComputerIsValid);
    }
}