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
        return await dbContext.Expenses.ToListAsync();
    }
}