using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computer;

public class ComputerFactory : IFactory<Computer>
{
    private readonly ICollection<Computer> _computerList;

    public ComputerFactory(ICollection<Computer> computerList)
    {
        _computerList = computerList;
    }

    public Computer CreateByName(string name)
    {
        Computer computer =
            _computerList.FirstOrDefault(computer =>
                (computer.Name ?? string.Empty).Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong computer name");
        return computer.Clone();
    }
}