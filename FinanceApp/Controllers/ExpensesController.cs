using FinanceApp.Data;
using FinanceApp.Data.Services;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    [Route("[controller]")]
    public class ExpensesController(IExpense _expense) : Controller
    {





        [Route("/")]
        public async Task<IActionResult> Index()
        {

            var expenses = await _expense.GetAll();

            return View(expenses);
        }

        [Route("[action]")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(Expense model)
        {
            if (ModelState.IsValid)
            {

               await _expense.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [Route("[action]")]
        public IActionResult GetChart()
        {
            var result = _expense.GetChartData();
            return Json(result);
        }


    }
}
