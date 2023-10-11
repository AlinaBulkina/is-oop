using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Tests
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
    public void FirstTest(ShipBase shuttle, ShipBase avgur)
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(0));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(shuttle);
        Result result2 = trip.TryShip(avgur);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
    }

    [Theory]
    [MemberData(nameof(SecondTestShips))]
    public void SecondTest(ShipBase vaklas1, ShipBase vaklas2)
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(1));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(vaklas1);
        Result result2 = trip.TryShip(vaklas2);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
    }

    [Theory]
    [MemberData(nameof(ThirdTestShips))]
    public void ThirdTest(ShipBase vaklas, ShipBase avgur, ShipBase meredian)
    {
        var route = new Route();
        route.AddPart(new NitrineNebula(1));
        var trip = new Trip(route);

        Result result1 = trip.TryShip(vaklas);
        Result result2 = trip.TryShip(avgur);
        Result result3 = trip.TryShip(meredian);

        Assert.False(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
        Assert.True(result3.TripIsSuccessful);
    }

    [Fact]
    public void Test4()
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
        Assert.True(result1.Cost < result2.Cost);
    }

    [Fact]
    public void Test5()
    {
        var route = new Route();
        route.AddPart(new HighDensityNebula(0));
        var trip = new Trip(route);
        ShipBase avgur = new Avgur();
        ShipBase stella = new Stella();

        Result result1 = trip.TryShip(avgur);
        Result result2 = trip.TryShip(stella);

        Assert.True(result1.TripIsSuccessful);
        Assert.True(result2.TripIsSuccessful);
    }

    [Fact]
    public void Test6()
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
    }

    [Fact]
    public void Test7()
    {
        var route = new Route();
        route.AddPart(new NitrineNebula(0));
        route.AddPart(new Space(2, 1));
        route.AddPart(new HighDensityNebula(2));
        var trip = new Trip(route);
        ShipBase avgur = new Avgur();
        ShipBase meredian = new Meredian();
        ShipBase stella = new Stella();
        ShipBase shuttle = new Shuttle();
        ShipBase vaklas = new Vaklas();

        Result result1 = trip.TryShip(avgur);
        Result result2 = trip.TryShip(meredian);
        Result result3 = trip.TryShip(stella);
        Result result4 = trip.TryShip(shuttle);
        Result result5 = trip.TryShip(vaklas);

        Assert.False(result1.TripIsSuccessful);
        Assert.False(result2.TripIsSuccessful);
        Assert.False(result3.TripIsSuccessful);
        Assert.False(result4.TripIsSuccessful);
        Assert.False(result5.TripIsSuccessful);
    }
}