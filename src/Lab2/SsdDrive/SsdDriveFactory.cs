using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.SsdDrive;

public class SsdDriveFactory : IFactory<SsdDrive>
{
    private readonly ICollection<SsdDrive> _ssdDriveList;

    public SsdDriveFactory(ICollection<SsdDrive> ssdDriveList)
    {
        _ssdDriveList = ssdDriveList;
    }

    public SsdDrive CreateByName(string name)
    {
        SsdDrive ssdDrive =
            _ssdDriveList.FirstOrDefault(ssdDrive => ssdDrive.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong SSD drive name");

        return ssdDrive.Clone();
    }
}