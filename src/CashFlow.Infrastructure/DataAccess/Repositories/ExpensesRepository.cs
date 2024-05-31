using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository(
    CashFlowDbContext dbContext,
    IUnitOfWork unitOfWork)
    : IExpensesWriteOnlyRepository, IExpensesReadOnlyRepository
{
    // AsNoTracking for cache
    public async Task<List<Expense>> GetAllAsync()
    {
        return await dbContext.Expenses.AsNoTracking().ToListAsync();
    }

    public async Task<Expense?> GetByIdAsync(long id)
    {
        return await dbContext.Expenses.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task AddAsync(Expense expense)
    {
        await dbContext.Expenses.AddAsync(expense);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var result = await dbContext.Expenses.FirstOrDefaultAsync(e => e.Id == id);
        if (result is null)
            return false;

        dbContext.Expenses.Remove(result);
        await unitOfWork.CommitAsync();
        return true;
    }
}