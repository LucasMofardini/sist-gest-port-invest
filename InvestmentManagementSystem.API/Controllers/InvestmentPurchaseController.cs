using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Investment;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvestmentPurchaseController(IInvestmentPurchaseService investmentPurchaseService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Investment>> Get()
    {
        try
        {
            var result = investmentPurchaseService.GetAllInvestmentPurchase();

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpGet("{id}")]
    public ActionResult<Investment> Get(int id)
    {
        try
        {
            var result = investmentPurchaseService.GetInvestmentPurchaseById(id);
            
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
    public ActionResult Post([FromBody] CreateInvestmentPurchaseDTO dto)
    {
        try
        {
            investmentPurchaseService.CreateInvestmentPurchase(dto);

            return Created();
        }
        catch (UnauthorizedAccessException e)
        {
            return Forbid(e.Message);
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    //@TODO falta fazer esse
    [HttpPut("{id}")]
    public ActionResult Post([FromBody] UpdateInvestmentPurchaseDTO dto, int id)
    {
        try
        {
            investmentPurchaseService.UpdateInvestmentPurchase(dto, id);

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
            investmentPurchaseService.DeleteInvestmentPurchaseById(id);

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