using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Application.UseCases.Expenses.Delete;

public class DeleteExpenseUseCase(
    IExpensesWriteOnlyRepository repository) : IDeleteExpenseUseCase
{
    public async Task Execute(long id)
    {
        await repository.DeleteAsync(id);
    }
}