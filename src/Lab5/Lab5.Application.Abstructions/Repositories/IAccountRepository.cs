using Lab5.Application.Models;

namespace Lab5.Application.Abstructions.Repositories;

public interface IAccountRepository
{
    User? FindAccountByNumberAndPin(long number, long pin);

    Admin? CheckSystemPassword(string systemPassword);
    void AddAccount(long number, long pin);
}