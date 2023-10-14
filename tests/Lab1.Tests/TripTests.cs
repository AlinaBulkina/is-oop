using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Xunit;
#pragma warning disable CA1707

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TripTests
{
    public static IEnumerable<object[]> FirstTestShips()
    {
        yield return new object[]
        {
            new Shuttle(),
            new Avgur(),
        };
    }

    public static IEnumerable<object[]> SecondTestShips()
    {
        var vaklas2 = new Vaklas();
        vaklas2.AddPhotonMod();
        yield return new object[]
        {
            new Vaklas(),
            vaklas2,
        };
    }

    public static IEnumerable<object[]> ThirdTestShips()
    {
        yield return new object[]
        {
            new Vaklas(),
            new Avgur(),
            new Meredian(),
        };
    }

    [Theory]
    [MemberData(nameof(FirstTestShips))]
    public void Choose_ShuttleOrAvgurInHighDensityNebula_ChooseNone(ShipBase shuttle, ShipBase avgur)
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(0, 2));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(shuttle);
        Result result2 = trip.TryShip(avgur);

        Assert.False(result1.TripIsSuccessful);
        Assert.False(result2.TripIsSuccessful);
        Assert.Null(trip.CompareResults());
    }

    [Theory]
    [MemberData(nameof(SecondTestShips))]
    public void Choose_VaklasWithOrWithoutPhotonModInHighDensityNebula_ChooseWithPhotonMod(
        ShipBase vaklas1, ShipBase vaklas2)
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(1, 1));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(vaklas1);
        Result result2 = trip.TryShip(vaklas2);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.Equal(vaklas2, trip.CompareResults());
    }

    [Theory]
    [MemberData(nameof(ThirdTestShips))]
    public void Choose_ValkasOrAvgurOrMeredianInNitrineNebula_ChooseMeredian(
        ShipBase vaklas, ShipBase avgur, ShipBase meredian)
    {
        var route = new Route();
        route.AddPart(new NitrineNebula(1));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(vaklas);
        Result result2 = trip.TryShip(avgur);
        Result result3 = trip.TryShip(meredian);

        Assert.True(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.True(result3.TripIsSuccessful);
        Assert.Equal(meredian, trip.CompareResults());
    }

    [Fact]
    public void Choose_ShuttleOrVaklasInSpace_ChooseShuttle()
    {
        var route = new Route();
        route.AddPart(new Space(1, 0));
        var trip = new Trip(route);
        ShipBase shuttle = new Shuttle();
        ShipBase vaklas = new Vaklas();

        Result result1 = trip.TryShip(shuttle);
        Result result2 = trip.TryShip(vaklas);

        Assert.True(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.Equal(shuttle, trip.CompareResults());
    }

    [Fact]
    public void Choose_AvgurOrStellaInHighDensityNebula_ChooseShuttle()
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(0, 2));
        var trip = new Trip(route);
        ShipBase avgur = new Avgur();
        ShipBase stella = new Stella();

        Result result1 = trip.TryShip(avgur);
        Result result2 = trip.TryShip(stella);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.Equal(stella, trip.CompareResults());
    }

    [Fact]
    public void Choose_ShuttleOrVaklasInNitrineNebula_ChooseVaklas()
    {
        var route = new Route();
        route.AddPart(new NitrineNebula(0));
        var trip = new Trip(route);
        ShipBase shuttle = new Shuttle();
        ShipBase vaklas = new Vaklas();

        Result result1 = trip.TryShip(shuttle);
        Result result2 = trip.TryShip(vaklas);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.Equal(vaklas, trip.CompareResults());
    }
}