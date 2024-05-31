namespace CashFlow.Application.UseCases.Expenses.Delete;

public interface IDeleteExpenseUseCase
{
    /// <summary>
    ///     This function returns true if the deletion has been done
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task Execute(long id);
}