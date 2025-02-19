using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<Expense> Expenses { get; set; }




}
