using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Computer;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class ComputerTests
{
    public static IEnumerable<object[]> ComputerFactory()
    {
        yield return new object[] { ComponentsData.ComputerFactory, };
    }

    public static IEnumerable<object[]> SecondTestComponents()
    {
        yield return new object[]
        {
            ComponentsData.FirstMotherboard, ComponentsData.FirstBios, ComponentsData.FirstFrame,
            ComponentsData.FirstHdd, ComponentsData.FirstRam, ComponentsData.FirstSsdDrive,
            ComponentsData.FirstVideoCard, ComponentsData.FirstCoolingSystem,
        };
    }

    public static IEnumerable<object[]> ThirdTestComponents()
    {
        yield return new object[]
        {
            ComponentsData.ComputerFactory,
            ComponentsData.LowPowerCoolingSystem,
        };
    }

    public static IEnumerable<object[]> ForthTestComponents()
    {
        yield return new object[]
        {
            ComponentsData.ComputerFactory,
            ComponentsData.BigVideoCard,
        };
    }

    [Theory]
    [MemberData(nameof(ComputerFactory))]
    public void ValidComputerTest(ComputerFactory computerFactory)
    {
        if (computerFactory is null) throw new ArgumentNullException(nameof(computerFactory));
        Computer.Computer computer = computerFactory.CreateByName("Intel Celeron N4020");
        Assert.True(computer.ComputerIsValid);
    }

    [Theory]
    [MemberData(nameof(SecondTestComponents))]
    public void ComputerWithoutCpuTest(
        Motherboard.Motherboard motherboard,
        Bios.Bios bios,
        Frame.Frame frame,
        Hdd.Hdd hdd,
        Ram.Ram ram,
        SsdDrive.SsdDrive ssdDrive,
        VideoCard.VideoCard videoCard,
        CoolingSystem.CoolingSystem coolingSystem)
    {
        Computer.Computer notValidComputer = new ComputerBuilder().WithName("Intel Celeron N4020")
            .WithMotherboard(motherboard)
            .WithBios(bios)
            .WithFrame(frame)
            .WithHdd(hdd)
            .WithRam(ram)
            .WithSsdDrive(ssdDrive)
            .WithVideoCard(videoCard)
            .WithCoolingSystem(coolingSystem)
            .Build();
        Assert.Equal("No CPU", notValidComputer.Comments.FirstOrDefault());
    }

    [Theory]
    [MemberData(nameof(ThirdTestComponents))]
    public void LowPowerCoolingTest(ComputerFactory computerFactory, CoolingSystem.CoolingSystem coolingSystem)
    {
        if (computerFactory is null) throw new ArgumentNullException(nameof(computerFactory));
        Computer.Computer computer = computerFactory.CreateByName("Intel Celeron N4020").Debuild()
            .WithCoolingSystem(coolingSystem).Build();
        Assert.Equal("Insufficient heat dissipation", computer.Comments.FirstOrDefault());
    }

    [Theory]
    [MemberData(nameof(ForthTestComponents))]
    public void BigVideCardTest(ComputerFactory computerFactory, VideoCard.VideoCard videoCard)
    {
        if (computerFactory is null) throw new ArgumentNullException(nameof(computerFactory));
        Computer.Computer computer = computerFactory.CreateByName("Intel Celeron N4020").Debuild()
            .WithVideoCard(videoCard).Build();
        Assert.Equal("Video card too big", computer.Comments.FirstOrDefault());
    }
}