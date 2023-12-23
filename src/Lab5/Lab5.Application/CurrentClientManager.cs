using Lab5.Application.Contracts.Clients;
using Lab5.Application.Models;

namespace Lab5.Application;

public class CurrentClientManager : ICurrentClientService
{
    public Client? Client { get; set; }
}