using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Bios;

public class BiosFactory : IFactory<Bios>
{
    private readonly ICollection<Bios> _biosList;

    public BiosFactory(ICollection<Bios> biosList)
    {
        _biosList = biosList;
    }

    public Bios CreateByName(string name)
    {
        Bios bios = _biosList.FirstOrDefault(bios => bios.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
                    throw new ArgumentException("Bios wrong name");
        return bios.Clone();
    }
}