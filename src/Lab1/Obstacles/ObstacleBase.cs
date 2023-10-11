using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class ObstacleBase
{
    public int Damage { get; protected set; }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(damage));
        }

        Damage -= damage;
    }

    public bool IsExist()
    {
        return Damage > 0;
    }
}