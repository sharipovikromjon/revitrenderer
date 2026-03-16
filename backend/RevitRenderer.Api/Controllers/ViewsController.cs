using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace RevitRenderer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var samplesDir = Path.Combine(Directory.GetCurrentDirectory(), "../samples");
            var files = Directory.Exists(samplesDir)
                ? Directory.EnumerateFiles(samplesDir).Select(Path.GetFileName).ToArray()
                : Array.Empty<string>();
            var views = files.Select((f, i) => new { id = i, name = f});
            return Ok(views);
        }

        [HttpPost("activate/{id}")]
        public IActionResult Activate(int id)
        {
            // store active view in server memory or file
            System.IO.File.WriteAllText("active.txt", id.ToString());
            return Ok(new { status = "activated", id });
        }
    }
}