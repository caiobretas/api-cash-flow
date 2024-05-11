using CashFlow.Communications.Requests.Register;
using CashFlow.Communications.Responses.Register;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);
        return new ResponseRegisterExpenseJson
        {
            Title = request.Title
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