using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Bios;
using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Cpu;
using Itmo.ObjectOrientedProgramming.Lab2.Frame;
using Itmo.ObjectOrientedProgramming.Lab2.Hdd;
using Itmo.ObjectOrientedProgramming.Lab2.Motherboard;
using Itmo.ObjectOrientedProgramming.Lab2.Ram;
using Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;
using Itmo.ObjectOrientedProgramming.Lab2.VideoCard;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public static class ComponentsData
{
    public static Cpu.Cpu FirstCpu { get; } = new CpuBuilder().WithName("Intel Core i3 12100")
        .WithFrequency(4)
        .WithCoresNumber(4)
        .WithSocket("LGA 1700")
        .WithSupportedMemoryFrequencies(4800)
        .WithTdp(60)
        .WithPowerConsumption(45)
        .Build();

    public static CoolingSystem.CoolingSystem FirstCoolingSystem { get; } = new CoolingSystemBuilder()
        .WithName("SE-214-XT")
        .WithSize(150)
        .WithSocket("AM4")
        .WithTdp(180)
        .Build();

    public static CoolingSystem.CoolingSystem LowPowerCoolingSystem { get; } = new CoolingSystemBuilder()
        .WithName("SEQW23-XT")
        .WithSize(150)
        .WithSocket("AM4")
        .WithTdp(40)
        .Build();

    public static Ram.Ram FirstRam { get; } = new RamBuilder().WithName("DEXP [DEXP4GD3UD16]")
        .WithAvailableMemory(4)
        .WithJedec(1)
        .WithFormFactor("DIMM")
        .WithDdr(3)
        .WithPowerConsumption(20)
        .Build();

    public static Hdd.Hdd FirstHdd { get; } = new HddBuilder().WithName("Toshiba DT01")
        .WithCapacity(1)
        .WithOperatingSpeed(7200)
        .WithPowerConsumption(20)
        .Build();

    public static VideoCard.VideoCard FirstVideoCard { get; } = new VideoCardBuilder().WithName("AFOX GeForce G 210")
        .WithHeight(145)
        .WithWidth(70)
        .WithMemory(1)
        .WithFrequency(550)
        .WithPowerConsumption(300)
        .Build();

    public static VideoCard.VideoCard BigVideoCard { get; } = new VideoCardBuilder().WithName("FOXYCAT 89.0")
        .WithHeight(260)
        .WithWidth(175)
        .WithMemory(1)
        .WithFrequency(550)
        .WithPowerConsumption(300)
        .Build();

    public static SsdDrive.SsdDrive FirstSsdDrive { get; } = new SsdDriveBuilder().WithName("AGI AI138")
        .WithConnection("SATA")
        .WithCapacity(256)
        .WithOperatingSpeed(530)
        .WithPowerConsumption(5)
        .Build();

    public static Frame.Frame FirstFrame { get; } = new FrameBuilder().WithName("DEXP DC-201M")
        .WithVideoCardMaxHeight(300)
        .WithVideoCardMaxWidth(150)
        .Build();

    public static Motherboard.Motherboard FirstMotherboard { get; } = new MotherboardBuilder()
        .WithName("ASUS Q87M-E/SI")
        .WithSocket("LGA 1700")
        .WithFormFactor("DIMM")
        .WithBios("EFI AMI BIOS")
        .Build();

    public static Bios.Bios FirstBios { get; } =
        new BiosBuilder().WithName("EFI AMI BIOS").WithAvailableCpu("Intel Core i3 12100").Build();

    public static Computer.Computer ValidComputer { get; } = new ComputerBuilder().WithName("Intel Celeron N4020")
        .WithMotherboard(FirstMotherboard)
        .WithBios(FirstBios)
        .WithCpu(FirstCpu)
        .WithFrame(FirstFrame)
        .WithHdd(FirstHdd)
        .WithRam(FirstRam)
        .WithSsdDrive(FirstSsdDrive)
        .WithVideoCard(FirstVideoCard)
        .WithCoolingSystem(FirstCoolingSystem)
        .Build();

    public static IFactory<Computer.Computer> ComputerFactory { get; } =
        new ComputerFactory(new List<Computer.Computer> { ValidComputer });
}