using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class DeflectorBase
{
    protected int HitPoints { get; set; }
    private int PhotonPoints { get; set; }
    private bool AntiNitrine { get; set; }

    public void AddPhotonMod()
    {
        PhotonPoints = 3;
    }

    public void AddAntiNitrineMod()
    {
        AntiNitrine = true;
    }

    public void TakeDamage(ObstacleBase obstacle)
    {
        if (obstacle is null)
        {
            throw new ArgumentNullException(nameof(obstacle));
        }

        if (obstacle is Flare)
        {
            if (PhotonPoints >= obstacle.Damage)
            {
                PhotonPoints -= obstacle.Damage;
                obstacle.TakeDamage(obstacle.Damage);
            }
            else
            {
                obstacle.TakeDamage(PhotonPoints);
                PhotonPoints = 0;
                HitPoints = 0;
            }
        }

        if (obstacle is SpaceWhale)
        {
            if (AntiNitrine)
            {
                obstacle.TakeDamage(obstacle.Damage);
            }
            else
            {
                if (HitPoints > 0)
                {
                    HitPoints = 0;
                    obstacle.TakeDamage(obstacle.Damage);
                }
            }
        }

        if (obstacle is Asteroid or Meteorite)
        {
            if (HitPoints >= obstacle.Damage)
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