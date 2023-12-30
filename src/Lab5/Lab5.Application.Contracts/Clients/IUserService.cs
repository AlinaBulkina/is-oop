using Lab5.Application.Contracts.Users;

namespace Lab5.Application.Contracts.Clients;

public interface IUserService
{
    Task<LoginResult> Login(long accountNumber, long pin);
    void AddMoney(int moneyAmount);
    void TakeMoney(int moneyAmount);
}