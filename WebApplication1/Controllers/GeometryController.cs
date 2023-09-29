using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeometryController : ControllerBase
{
    [HttpGet("circle")]
    public ActionResult<double> CalculateCircleArea(double radius)
    {
        try
        {
            double area = GeometryCalculator.CalculateCircleArea(radius);
            return area;
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("triangle")]
    public ActionResult<double> CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        try
        {
            double area = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
            return area;
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
}