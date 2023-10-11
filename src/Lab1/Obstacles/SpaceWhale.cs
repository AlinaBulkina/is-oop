using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class SpaceWhale : ObstacleBase
{
    public SpaceWhale(int spaceWhaleCount)
    {
        if (spaceWhaleCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(spaceWhaleCount));
        }

        Damage = 400 * spaceWhaleCount;
    }
}