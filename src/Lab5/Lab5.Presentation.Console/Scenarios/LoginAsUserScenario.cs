using Lab5.Application.Contracts.Clients;
using Lab5.Application.Contracts.Users;
using Spectre.Console;

namespace Lab5.Presentation.Console.Scenarios;

public class LoginAsUserScenario : IScenario
{
    private readonly IUserService _userService;

    public LoginAsUserScenario(IUserService userService)
    {
        _userService = userService;
    }

    public string Name => "Login as user";

    public async Task Run()
    {
        long accountNumber = AnsiConsole.Ask<long>("Enter your account number");
        long pin = AnsiConsole.Ask<long>("Enter your pin");

        LoginResult result = await _userService.Login(accountNumber, pin).ConfigureAwait(false);

        string message = result switch
        {
            LoginResult.Success => "Successful login",
            LoginResult.WrongAccountNumberOrPin => "User not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}