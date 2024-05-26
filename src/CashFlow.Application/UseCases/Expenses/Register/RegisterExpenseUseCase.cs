using CashFlow.Communications.Requests.Register;
using CashFlow.Communications.Responses.Register;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Enums;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase(IExpensesRepository repository, IUnitOfWork unitOfWork) : IRegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        Expense expense = new()
        {
            Title = request.Title,
            Amount = request.Amount,
            Date = request.Date,
            Description = request.Description,
            PaymentType = (PaymentType)request.PaymentType
        };

        repository.Add(expense);

        unitOfWork.Commit();

        return new ResponseRegisterExpenseJson
        {
            Title = expense.Title
        };
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);

        if (result.IsValid) return;

        var errors = result.Errors.Select(x => x.ErrorMessage).ToList();
        throw new ErrorOnValidationException(errors);
    }
}