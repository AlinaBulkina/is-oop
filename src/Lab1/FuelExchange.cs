using System;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public static class FuelExchange
{
    private const int ExchangeRate = 30;

    public static int Exchange(int fuelAmount)
    {
        if (fuelAmount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(fuelAmount));
        }

        return fuelAmount * ExchangeRate;
    }
}