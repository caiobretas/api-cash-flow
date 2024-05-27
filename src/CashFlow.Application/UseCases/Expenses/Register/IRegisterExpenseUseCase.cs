using CashFlow.Communications.Requests.Register;
using CashFlow.Communications.Responses.Register;

namespace CashFlow.Application.UseCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
    public Task<ResponseRegisterExpenseJson> Execute(RequestRegisterExpenseJson request);
}