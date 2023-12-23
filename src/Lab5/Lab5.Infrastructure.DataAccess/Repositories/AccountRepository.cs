using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Lab5.Application.Abstructions.Repositories;
using Lab5.Application.Models;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;
    private readonly string _systemPassword;

    public AccountRepository(IPostgresConnectionProvider connectionProvider, string systemPassword)
    {
        _connectionProvider = connectionProvider;
        _systemPassword = systemPassword;
    }

    public User? FindAccountByNumberAndPin(string number, string pin)
    {
        const string sql = """
                           select account_number, account_pin
                           from accounts
                           where account_number = :number
                           and account_pin = :pin;
                           """;

#pragma warning disable CA2012
        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default)
#pragma warning restore CA2012
            .GetAwaiter()
            .GetResult();

#pragma warning disable CA2000
        using NpgsqlCommand command = new NpgsqlCommand(sql, connection)
#pragma warning restore CA2000
            .AddParameter("account_number", number);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new User(reader.GetInt64(0));
    }

    public Admin? CheckSystemPassword(string systemPassword)
    {
        if (systemPassword != _systemPassword)
        {
            return null;
        }

        return new Admin();
    }
}