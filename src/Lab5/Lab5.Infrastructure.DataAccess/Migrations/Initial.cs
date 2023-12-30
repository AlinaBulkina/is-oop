using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5.Infrastructure.DataAccess.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """

        create type order_result_state as enum
        (
            'completed',
            'rejected'
        );

        create table accounts
        (
            account_number bigint primary key generated always as identity ,
            account_pin bigint
        );

        """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
        """
        
        drop table accounts;
        drop type order_result_state
        """;
}