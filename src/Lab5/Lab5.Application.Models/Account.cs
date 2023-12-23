namespace Lab5.Application.Models;

public class Account
{
    public Account()
    {
        MoneyAmount = 0;
    }

    public int MoneyAmount { get; private set; }

    public void AddMoney(int money)
    {
        MoneyAmount += money;
    }

    public bool TakeMoney(int money)
    {
        if (MoneyAmount >= money)
        {
            MoneyAmount -= money;
            return true;
        }

        return false;
    }
}