using Lab5.Application.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class TransactionTest
{
    [Fact]
    public void AddSomeMoney()
    {
        var account = new Account();
        account.AddMoney(100);
        Assert.False(account.TakeMoney(200));
    }

    [Fact]
    public void TakeSomeMoney()
    {
        var account = new Account();
        account.AddMoney(100);
        Assert.True(account.TakeMoney(50));
    }

    [Fact]
    public void SomeMoney()
    {
        var account = new Account();
        account.AddMoney(100);
        Assert.True(account.TakeMoney(50));
        Assert.Equal(50, account.MoneyAmount);
    }
}