namespace Itmo.ObjectOrientedProgramming.Lab2.Computer;

public class ComputerBuilder
{
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

    public ComputerBuilder WithName(string? name)
    {
        _name = name;
        return this;
    }

    public ComputerBuilder WithMotherboard(Motherboard.Motherboard? motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public ComputerBuilder WithCpu(Cpu.Cpu? cpu)
    {
        _cpu = cpu;
        return this;
    }

    public ComputerBuilder WithBios(Bios.Bios? bios)
    {
        _bios = bios;
        return this;
    }

    public ComputerBuilder WithCoolingSystem(CoolingSystem.CoolingSystem? coolingSystem)
    {
        _coolingSystem = coolingSystem;
        return this;
    }

    public ComputerBuilder WithRam(Ram.Ram? ram)
    {
        _ram = ram;
        return this;
    }

    public ComputerBuilder WithVideoCard(VideoCard.VideoCard? videoCard)
    {
        _videoCard = videoCard;
        return this;
    }

    public ComputerBuilder WithSsdDrive(SsdDrive.SsdDrive? ssdDrive)
    {
        _ssdDrive = ssdDrive;
        return this;
    }

    public ComputerBuilder WithHdd(Hdd.Hdd? hdd)
    {
        _hdd = hdd;
        return this;
    }

    public ComputerBuilder WithFrame(Frame.Frame? frame)
    {
        _frame = frame;
        return this;
    }

    public Computer Build()
    {
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
            _frame);
    }
}