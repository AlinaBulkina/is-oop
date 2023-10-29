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
        Frame.Frame? frame)
    {
        Comments = new List<string>();
        ComputerIsValid = true;

        if (string.IsNullOrWhiteSpace(name)) Comments.Add("No name");

        if (motherboard is null) Comments.Add("No motherboard");
        if (cpu is null) Comments.Add("No CPU");
        if (bios is null) Comments.Add("No BIOS");
        if (coolingSystem is null) Comments.Add("No cooling system");
        if (ram is null) Comments.Add("No Ram");
        if (videoCard is null && cpu is not null && cpu.VideoCore == false) Comments.Add("No video card");
        if (ssdDrive is null && hdd is null) Comments.Add("No drive");
        if (frame is null) Comments.Add("No frame");

        if (motherboard is not null && cpu is not null && motherboard.Socket != cpu.Socket)
        {
            Comments.Add("Different sockets");
        }

        if (videoCard is not null && frame is not null &&
            (videoCard.Height > frame.VideoCardMaxHeight | videoCard.Width > frame.VideoCardMaxWidth))
        {
            Comments.Add("Video card too big");
        }

        if (cpu is not null && coolingSystem is not null && cpu.Tdp > coolingSystem.Tdp)
        {
            Comments.Add("Insufficient heat dissipation");
        }

        if (Comments.Count > 0) ComputerIsValid = false;

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
    }

    public string? Name { get; }
    public Motherboard.Motherboard? Motherboard { get; }
    public Cpu.Cpu? Cpu { get; }
    public Bios.Bios? Bios { get; }
    public CoolingSystem.CoolingSystem? CoolingSystem { get; }
    public Ram.Ram? Ram { get; }
    public VideoCard.VideoCard? VideoCard { get; }
    public SsdDrive.SsdDrive? SsdDrive { get; }
    public Hdd.Hdd? Hdd { get; }
    public Frame.Frame? Frame { get; }
    public ICollection<string> Comments { get; }
    public bool ComputerIsValid { get; }

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
            Frame);
    }

    public ComputerBuilder Debuild()
    {
        return new ComputerBuilder().WithName(Name)
            .WithMotherboard(Motherboard).WithBios(Bios).WithCpu(Cpu).WithFrame(Frame).WithHdd(Hdd)
            .WithRam(Ram).WithSsdDrive(SsdDrive).WithVideoCard(VideoCard)
            .WithCoolingSystem(CoolingSystem);
    }
}