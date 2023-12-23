namespace Lab5.Application.Models;

public class User : Client
{
    public User(long accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public long AccountNumber { get; init; }
}