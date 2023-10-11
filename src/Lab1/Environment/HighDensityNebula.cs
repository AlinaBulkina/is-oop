using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class HighDensityNebula : EnvironmentBase
{
    public HighDensityNebula(int flareCount)
    {
        if (flareCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(flareCount));
        }

        FlareCount = flareCount;
    }
}