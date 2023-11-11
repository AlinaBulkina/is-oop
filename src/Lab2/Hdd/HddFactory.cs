using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Hdd;

public class HddFactory : IFactory<Hdd>
{
    private readonly ICollection<Hdd> _hddList;

    public HddFactory(ICollection<Hdd> hddList)
    {
        _hddList = hddList;
    }

    public Hdd CreateByName(string name)
    {
        Hdd hdd =
            _hddList.FirstOrDefault(hdd => hdd.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong HDD name");

        return hdd.Clone();
    }
}