using Lab5.Application.Abstructions.Repositories;
using Lab5.Application.Contracts.Clients;
using Lab5.Application.Contracts.Users;
using Lab5.Application.Models;

namespace Lab5.Application;

internal class UserService : IUserService
{
    private readonly IAccountRepository _repository;
    private readonly CurrentClientManager _currentClientManager;

    public UserService(IAccountRepository repository, CurrentClientManager currentClientManager)
    {
        _repository = repository;
        _currentClientManager = currentClientManager;
    }

    public Task<LoginResult> Login(string accountNumber, string accountPin)
    {
        User? user = _repository.FindAccountByNumberAndPin(accountNumber, accountPin);

        if (user is null)
        {
            return Task.FromResult<LoginResult>(new LoginResult.WrongAccountNumberOrPin());
        }

        _currentClientManager.Client = user;
        return Task.FromResult<LoginResult>(new LoginResult.Success());
    }

    public void AddMoney(int moneyAmount)
    {
        throw new NotImplementedException();
    }

    public void TakeMoney(int moneyAmount)
    {
        throw new NotImplementedException();
    }
}