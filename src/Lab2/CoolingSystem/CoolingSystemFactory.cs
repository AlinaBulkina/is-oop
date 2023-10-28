using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;

public class CoolingSystemFactory : IFactory<CoolingSystem>
{
    private readonly ICollection<CoolingSystem> _coolingSystemList;

    public CoolingSystemFactory(ICollection<CoolingSystem> coolingSystemList)
    {
        _coolingSystemList = coolingSystemList;
    }

    public CoolingSystem CreateByName(string name)
    {
        CoolingSystem coolingSystem =
            _coolingSystemList.FirstOrDefault(coolingSystem =>
                coolingSystem.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong cooling system name");

        return coolingSystem.Clone();
    }
}