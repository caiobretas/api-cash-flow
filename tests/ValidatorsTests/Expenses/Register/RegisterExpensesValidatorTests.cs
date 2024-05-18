using System.Runtime.CompilerServices;
using CommonTestUtilities.Requests;

namespace ValidatorsTests.Expenses.Register;

public class RegisterExpensesValidatorTests
{
    [Fact]
    public void Success()
    {
        var register = RequestRegisterExpenseJsonBuilder.Build();
    }
}