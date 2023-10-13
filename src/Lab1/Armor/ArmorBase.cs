using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Armor;

public class ArmorBase
{
    protected int HitPoints { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        if (obstacle is null)
        {
            throw new ArgumentNullException(nameof(obstacle));
        }

        if (obstacle is Meteorite | obstacle is Asteroid)
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