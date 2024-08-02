using InvestmentManagementSystem.Application.DTOs.Employee;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Employee;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentManagementSystem.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        try
        {
            var result = employeeService.GetAllEmployees();

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
    
    [HttpGet("{id}")]
    public ActionResult<Employee> Get(int id)
    {
        try
        {
            var result = employeeService.GetEmployeeById(id);
            
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
    public ActionResult Post([FromBody] CreateEmployeeDTO dto)
    {
        try
        {
            employeeService.CreateEmployee(dto);

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
    public ActionResult Post([FromBody] UpdateEmployeeDTO dto, int id)
    {
        try
        {
            employeeService.UpdateEmployee(dto, id);

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
            employeeService.DeleteEmployeeById(id);

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