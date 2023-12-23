using Lab5.Application.Contracts.Users;

namespace Lab5.Application.Contracts.Clients;

public interface IAdminService
{
    LoginResult Login(string systemPassword);
}