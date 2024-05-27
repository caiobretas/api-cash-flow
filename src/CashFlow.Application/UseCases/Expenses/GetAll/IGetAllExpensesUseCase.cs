using CashFlow.Communications.Responses.GetAll;

namespace CashFlow.Application.UseCases.Expenses.GetAll;

public interface IGetAllExpensesUseCase
{
    public Task<ResponseExpensesJson> Execute();
}