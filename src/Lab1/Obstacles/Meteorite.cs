using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Meteorite : ObstacleBase
{
    public Meteorite(int meteoriteCount)
    {
        if (meteoriteCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(meteoriteCount));
        }

        Damage = 30 * meteoriteCount;
    }
}