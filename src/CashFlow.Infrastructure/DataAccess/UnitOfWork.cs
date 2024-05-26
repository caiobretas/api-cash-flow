using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAccess;

internal class UnitOfWork(CashFlowDbContext dbContext) : IUnitOfWork
{
    public void Commit()
    {
        dbContext.SaveChanges();
    }
}