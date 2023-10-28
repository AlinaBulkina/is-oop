using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Motherboard;

public class MotherboardFactory : IFactory<Motherboard>
{
    private readonly ICollection<Motherboard> _motherboardList;

    public MotherboardFactory(ICollection<Motherboard> motherboardList)
    {
        _motherboardList = motherboardList;
    }

    public Motherboard CreateByName(string name)
    {
        Motherboard motherboard =
            _motherboardList.FirstOrDefault(motherboard =>
                motherboard.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong motherboard name");
        return motherboard.Clone();
    }
}