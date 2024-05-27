using CashFlow.Communications.Responses.GetById;

namespace CashFlow.Application.UseCases.Expenses.GetById;

public interface IGetByIdUseCase
{
    public Task<ResponseExpenseJson> Execute(long id);
}