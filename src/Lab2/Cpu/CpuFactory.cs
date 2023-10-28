using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Cpu;

public class CpuFactory : IFactory<Cpu>
{
    private readonly ICollection<Cpu> _cpuList;

    public CpuFactory(ICollection<Cpu> cpuList)
    {
        _cpuList = cpuList;
    }

    public Cpu CreateByName(string name)
    {
        Cpu cpu = _cpuList.FirstOrDefault(cpu => cpu.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
                      throw new ArgumentException("Wrong cpu name");

        return cpu.Clone();
    }
}