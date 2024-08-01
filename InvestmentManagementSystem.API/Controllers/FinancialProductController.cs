using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FinancialProductController(IFinancialProductService financialProductService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<FinancialProduct>> Get()
    {
        try
        {
            var result = financialProductService.GetAllFinancialProduct();

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpGet("{id}")]
    public ActionResult<FinancialProduct> Get(int id)
    {
        try
        {
            var result = financialProductService.GetFinancialProductById(id);
            
            return Ok(result);
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpPost]
    public ActionResult Post([FromBody] FinancialProductDTO dto)
    {
        try
        {
            financialProductService.CreateOrUpdateFinancialProduct(dto);

            return Created();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpPut("{id}")]
    public ActionResult Post([FromBody] FinancialProductDTO dto, int id)
    {
        try
        {
            financialProductService.CreateOrUpdateFinancialProduct(dto, id);

            return Ok();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpDelete("{id}")]
    public ActionResult Post(int id)
    {
        try
        {
            financialProductService.DeleteFinancialProductById(id);

            return NoContent();
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(new { message = e.Message });
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}