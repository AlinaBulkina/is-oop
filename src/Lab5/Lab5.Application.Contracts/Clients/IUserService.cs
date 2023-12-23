using Lab5.Application.Contracts.Users;

namespace Lab5.Application.Contracts.Clients;

public interface IUserService
{
    Task<LoginResult> Login(string accountNumber, string pin);
    void AddMoney(int moneyAmount);
    void TakeMoney(int moneyAmount);
}