using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Clients;

namespace Lab5.Presentation.Console.Scenarios;

public class LoginAsAdminScenarioProvider : IScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentClientService _currentClient;

    public LoginAsAdminScenarioProvider(
        IAdminService service,
        ICurrentClientService currentClient)
    {
        _service = service;
        _currentClient = currentClient;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentClient.Client is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new LoginAsAdminScenario(_service);
        return true;
    }
}