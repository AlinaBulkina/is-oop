using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer;

public class ComputerBuilder
{
    private readonly ICollection<string> _comments = new List<string>();
    private string? _name;
    private Motherboard.Motherboard? _motherboard;
    private Cpu.Cpu? _cpu;
    private Bios.Bios? _bios;
    private CoolingSystem.CoolingSystem? _coolingSystem;
    private Ram.Ram? _ram;
    private VideoCard.VideoCard? _videoCard;
    private SsdDrive.SsdDrive? _ssdDrive;
    private Hdd.Hdd? _hdd;
    private Frame.Frame? _frame;
    private bool _computerIsValid = true;

    public ComputerBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ComputerBuilder WithMotherboard(Motherboard.Motherboard motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public ComputerBuilder WithCpu(Cpu.Cpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public ComputerBuilder WithBios(Bios.Bios bios)
    {
        _bios = bios;
        return this;
    }

    public ComputerBuilder WithCoolingSystem(CoolingSystem.CoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        return this;
    }

    public ComputerBuilder WithRam(Ram.Ram ram)
    {
        _ram = ram;
        return this;
    }

    public ComputerBuilder WithVideoCard(VideoCard.VideoCard videoCard)
    {
        _videoCard = videoCard;
        return this;
    }

    public ComputerBuilder WithSsdDrive(SsdDrive.SsdDrive ssdDrive)
    {
        _ssdDrive = ssdDrive;
        return this;
    }

    public ComputerBuilder WithHdd(Hdd.Hdd hdd)
    {
        _hdd = hdd;
        return this;
    }

    public ComputerBuilder WithFrame(Frame.Frame frame)
    {
        _frame = frame;
        return this;
    }

    public Computer Build()
    {
        if (_name is null)
        {
            _comments.Add("No name");
        }

        if (_motherboard is null)
        {
            _computerIsValid = false;
            _comments.Add("No motherboard");
        }

        if (_cpu is null)
        {
            _computerIsValid = false;
            _comments.Add("No CPU");
        }

        if (_bios is null)
        {
            _computerIsValid = false;
            _comments.Add("No BIOS");
        }

        if (_coolingSystem is null)
        {
            _computerIsValid = false;
            _comments.Add("No cooling system");
        }

        if (_ram is null)
        {
            _computerIsValid = false;
            _comments.Add("No Ram");
        }

        if (_videoCard is null && _cpu is not null && _cpu.VideoCore == false)
        {
            _computerIsValid = false;
            _comments.Add("No video card");
        }

        if (_ssdDrive is null && _hdd is null)
        {
            _computerIsValid = false;
            _comments.Add("No drive");
        }

        if (_frame is null)
        {
            _computerIsValid = false;
            _comments.Add("No frame");
        }

        return new Computer(
            _name,
            _motherboard,
            _cpu,
            _bios,
            _coolingSystem,
            _ram,
            _videoCard,
            _ssdDrive,
            _hdd,
            _frame,
            _comments,
            _computerIsValid);
    }
}