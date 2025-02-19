using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models;

public class Expense
{
    
    public int Id { get; set; }
    [Required]
    public string Description { get; set; } = default!;
    [Required]
    [Range(0.01,double.MaxValue,ErrorMessage ="Amount needs to be higher than zero")]
    public double Amount { get; set; }
    [Required]
    public string Category { get; set; } = default!;
    public DateTime Date { get; set; }= DateTime.UtcNow;






}
