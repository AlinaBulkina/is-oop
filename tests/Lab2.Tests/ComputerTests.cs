using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Bios;
using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Cpu;
using Itmo.ObjectOrientedProgramming.Lab2.Frame;
using Itmo.ObjectOrientedProgramming.Lab2.Hdd;
using Itmo.ObjectOrientedProgramming.Lab2.Ram;
using Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;
using Itmo.ObjectOrientedProgramming.Lab2.VideoCard;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class ComputerTests
{
    private static readonly Cpu.Cpu FirstCpu = new CpuBuilder().WithName("Intel Core i3 12100").WithFrequency(4)
        .WithCoresNumber(4).WithSocket("LGA 1700").WithSupportedMemoryFrequencies(4800).WithTdp(60)
        .WithPowerConsumption(45).Build();

    private static readonly CoolingSystem.CoolingSystem FirstCoolingSystem = new CoolingSystemBuilder()
        .WithName("SE-214-XT").WithSize(150).WithSocket("AM4").WithTdp(180).Build();

    private static readonly Ram.Ram FirstRam = new RamBuilder().WithName("DEXP [DEXP4GD3UD16]").WithAvailableMemory(4)
        .WithJedec(1).WithFormFactor("DIMM").WithDdr(3).WithPowerConsumption(20).Build();

    private static readonly Hdd.Hdd FirstHdd = new HddBuilder().WithName("Toshiba DT01").WithCapacity(1)
        .WithOperatingSpeed(7200).WithPowerConsumption(20).Build();

    private static readonly VideoCard.VideoCard FirstVideoCard = new VideoCardBuilder().WithName("AFOX GeForce G 210")
        .WithHeight(145).WithWidth(70).WithMemory(1).WithFrequency(550).WithPowerConsumption(300).Build();

    private static readonly SsdDrive.SsdDrive FirstSsdDrive = new SsdDriveBuilder().WithName("AGI AI138")
        .WithConnection("SATA").WithCapacity(256).WithOperatingSpeed(530).WithPowerConsumption(5).Build();

    private static readonly Frame.Frame FirstFrame = new FrameBuilder().WithName("DEXP DC-201M")
        .WithVideoCardMaxHeight(300).WithVideoCardMaxWidth(150).Build();

    private static readonly Motherboard.Motherboard FirstMotherboard = new Motherboard.MotherboardBuilder()
        .WithName("ASUS Q87M-E/SI").WithSocket("LGA 1700").WithFormFactor("DIMM").WithBios("EFI AMI BIOS").Build();

    private static readonly Bios.Bios FirstBios =
        new BiosBuilder().WithName("EFI AMI BIOS").WithAvailableCpu("Intel Core i3 12100").Build();

    private static readonly Computer.Computer ValidComputer = new ComputerBuilder().WithName("Intel Celeron N4020")
        .WithMotherboard(FirstMotherboard).WithBios(FirstBios).WithCpu(FirstCpu).WithFrame(FirstFrame).WithHdd(FirstHdd)
        .WithRam(FirstRam).WithSsdDrive(FirstSsdDrive).WithVideoCard(FirstVideoCard)
        .WithCoolingSystem(FirstCoolingSystem).Build();

    private readonly IFactory<Computer.Computer> _computerFactory =
        new ComputerFactory(new List<Computer.Computer> { ValidComputer });

    [Fact]
    public void ValidComputerTest()
    {
        Computer.Computer? computer = _computerFactory.CreateByName("Intel Celeron N4020");
        if (computer is null)
        {
            throw new ArgumentNullException(nameof(computer));
        }

        Assert.True(computer.ComputerIsValid);
    }

    [Fact]
    public void ComputerWithoutCpu()
    {
        Computer.Computer notValidComputer = new ComputerBuilder().WithName("Intel Celeron N4020")
            .WithMotherboard(FirstMotherboard).WithBios(FirstBios).WithFrame(FirstFrame).WithHdd(FirstHdd)
            .WithRam(FirstRam).WithSsdDrive(FirstSsdDrive).WithVideoCard(FirstVideoCard)
            .WithCoolingSystem(FirstCoolingSystem).Build();
        Assert.Equal("No CPU", notValidComputer.Comments.FirstOrDefault());
    }
}