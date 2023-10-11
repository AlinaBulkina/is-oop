using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Armor;

public class ArmorBase
{
    protected int HitPoints { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        if (obstacle == null)
        {
            throw new ArgumentNullException(nameof(obstacle));
        }

        if (obstacle.GetType() == typeof(Meteorite) | obstacle.GetType() == typeof(Asteroid))
        {
            if (HitPoints > obstacle.Damage)
            {
                HitPoints -= obstacle.Damage;
                obstacle.TakeDamage(obstacle.Damage);
            }
            else
            {
                obstacle.TakeDamage(HitPoints);
                HitPoints = 0;
            }
        }
    }
}