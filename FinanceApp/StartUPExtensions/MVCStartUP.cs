using FinanceApp.Data;
using FinanceApp.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.StartUPExtensions
{
    public static class MVCStartUP
    {


        public static void StartUPExtension(this IServiceCollection services , IConfiguration config)
        {
            services.AddDbContext<AppDbContext>( options =>
            {
                options.UseSqlServer(config.GetConnectionString("LocalConnectionString"));
            });


            services.AddScoped<IExpense, ExpenseService>();


        }



    }
}
