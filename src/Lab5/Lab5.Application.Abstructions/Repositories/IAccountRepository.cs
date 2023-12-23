using Lab5.Application.Models;

namespace Lab5.Application.Abstructions.Repositories;

public interface IAccountRepository
{
    User? FindAccountByNumberAndPin(string number, string pin);
    Admin? CheckSystemPassword(string systemPassword);
}