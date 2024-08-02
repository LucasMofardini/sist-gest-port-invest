using InvestmentManagementSystem.Domain.Customer;
using InvestmentManagementSystem.Domain.Employee;
using InvestmentManagementSystem.Domain.Investment;
using Microsoft.EntityFrameworkCore;

namespace InvestmentManagementSystem.Infrastructure.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> opts) : base(opts)
    {
        
    }
    
    public DbSet<FinancialProduct> FinancialProduct { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Investment> InvestmentPurchase { get; set; }
    public DbSet<Employee> Employee { get; set; }
}