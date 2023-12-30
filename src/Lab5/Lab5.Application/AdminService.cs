using Lab5.Application.Abstructions.Repositories;
using Lab5.Application.Contracts.Clients;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;

namespace Lab5.Application;

public class AdminService : IAdminService
{
    private readonly IAccountRepository _repository;
    private readonly CurrentClientManager _currentClientManager;

    public AdminService(IAccountRepository repository, CurrentClientManager currentClientManager)
    {
        _repository = repository;
        _currentClientManager = currentClientManager;
    }

    public Task<LoginResult> Login(string systemPassword)
    {
        Admin? admin = _repository.CheckSystemPassword(systemPassword);

        if (admin is null)
        {
            return Task.FromResult<LoginResult>(new LoginResult.WrongAccountNumberOrPin());
        }

        _currentClientManager.Client = admin;
        return Task.FromResult<LoginResult>(new LoginResult.Success());
    }

    public void AddAccount(long accountNumber, long accountPin)
    {
        _repository.AddAccount(accountNumber, accountPin);
    }
}