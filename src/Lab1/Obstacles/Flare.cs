using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Flare : ObstacleBase
{
    public Flare(int flareCount)
    {
        if (flareCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(flareCount));
        }

        Damage = flareCount;
    }
}