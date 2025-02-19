using FinanceApp.DTOs;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;


namespace FinanceApp.Data.Services;

public class ExpenseService(AppDbContext _db) : IExpense
{
    public async Task Add(Expense expense)
    {
        await _db.Expenses.AddAsync(expense);
        await _db.SaveChangesAsync();

    }

    public async Task<IEnumerable<Expense>> GetAll()
    {
      var result=  await _db.Expenses.ToListAsync();
        return result;
    }

    public List<ExpensesDTO> GetChartData()
    {
        var data = _db.Expenses
                        .GroupBy(e => e.Category)
                        .Select(e => new ExpensesDTO
                        {
                            Category = e.Key,
                            Total = e.Sum(e => e.Amount)
                        }).ToList();
        return data;
    }
}
