using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ram;

public class RamFactory : IFactory<Ram>
{
    private readonly ICollection<Ram> _ramList;

    public RamFactory(ICollection<Ram> ramList)
    {
        _ramList = ramList;
    }

    public Ram CreateByName(string name)
    {
        Ram ram = _ramList.FirstOrDefault(ram => ram.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
                           throw new ArgumentException("Wrong RAM name");

        return ram.Clone();
    }
}