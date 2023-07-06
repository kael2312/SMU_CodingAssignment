using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shape.Implements;
using Shape.Models;

namespace Shape.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : ControllerBase
    {
        [HttpPost]
        public IActionResult DrawSquare([FromBody]DrawRequestModel request)
        {
            DrawContext drawContext = new DrawContext();
            string result = String.Empty;
            switch (request.Shape)
            {
                case "square":
                    drawContext.SetDrawType(new DrawSquare());                    
                    break;
                case "triangle":
                    drawContext.SetDrawType(new DrawTriangle());
                    break;
                default:
                    return BadRequest(new { Message = "Shape Not Found" });
            }
            if (request.Char == null)
            {
                result = drawContext.Draw(request.Size);
            }
            else
            {
                result = drawContext.Draw(request.Size, (char)request.Char);
            }

            return Ok(result);
        }
    }
}
