using Lab5.Application.Models;

namespace Lab5.Application.Contracts.Clients;

public interface ICurrentClientService
{
    Client? Client { get; }
}