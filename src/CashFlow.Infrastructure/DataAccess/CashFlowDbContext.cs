using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=caio;Pwd=20022001;";
        var mySqlVersion = new MySqlServerVersion(new Version(8, 4, 0));
        optionsBuilder.UseMySql(connectionString, mySqlVersion);
    }
}