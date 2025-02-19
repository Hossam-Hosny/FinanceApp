using FinanceApp.DTOs;
using FinanceApp.Models;

namespace FinanceApp.Data.Services;

public interface IExpense
{
    Task<IEnumerable<Expense>> GetAll();
    Task Add (Expense expense);
    List<ExpensesDTO> GetChartData();
}
