using Lab5.Application.Contracts.Users;

namespace Lab5.Application.Contracts.Clients;

public interface IAdminService
{
    Task<LoginResult> Login(string systemPassword);
    void AddAccount(long accountNumber, long accountPin);
}