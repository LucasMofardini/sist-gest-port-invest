using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Application.Services;
using InvestmentManagementSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace InvestmentManagementSystem.Test;

public class IntegrationTests
{
    private readonly HttpClient _client;

    public IntegrationTests(HttpClient client)
    {
        _client = client;

        var builder = WebApplication.CreateBuilder();

            var connectionString = builder.Configuration.GetConnectionString("InvestmentManagementSystem");

            builder.Services.AddDbContext<Context>(opts =>
                opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            
            builder.Services.AddScoped<IFinancialProductService, FinancialProductService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IInvestmentPurchaseService, InvestmentPurchaseService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<DbContext, Context>();
        
    }
    
    [Fact]
    public async Task Test_GetInvestimentoByClienteId_ReturnsSuccess()
    {
        // Arrange
        var id = 1;
        var requestUri = $"/api/InvestmentPurchase/Customer/{id}";

        // Act
        var response = await _client.GetAsync(requestUri);

        // Assert
        response.EnsureSuccessStatusCode(); // Verifica se o status code é 2xx
        var responseBody = await response.Content.ReadAsStringAsync();
        Assert.Contains("", responseBody); // Verifica o conteúdo da resposta
    }
}