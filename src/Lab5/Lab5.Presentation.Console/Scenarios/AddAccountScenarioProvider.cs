using System.Diagnostics.CodeAnalysis;
using Lab5.Application.Contracts.Clients;

namespace Lab5.Presentation.Console.Scenarios;

public class AddAccountScenarioProvider : IScenarioProvider
{
    private readonly IAdminService _service;
    private readonly ICurrentClientService _currentClient;

    public AddAccountScenarioProvider(
        IAdminService service,
        ICurrentClientService currentClient)
    {
        _service = service;
        _currentClient = currentClient;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IScenario? scenario)
    {
        scenario = new AddAccountScenario(_service);
        return true;
    }
}