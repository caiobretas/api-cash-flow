using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository(CashFlowDbContext dbContext) : IExpensesRepository
{
    public async Task AddAsync(Expense expense)
    {
        await dbContext.Expenses.AddAsync(expense);
    }

    public async Task<List<Expense>> GetAllAsync()
    {
        // AsNoTracking para não armazenar o Cache
        return await dbContext.Expenses.AsNoTracking().ToListAsync();
    }
}