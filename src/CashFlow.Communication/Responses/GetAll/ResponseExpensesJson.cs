namespace CashFlow.Communications.Responses.GetAll;

public class ResponseExpensesJson
{
    public List<ResponseShortExpensesJson> Expenses { get; set; } = [];
}