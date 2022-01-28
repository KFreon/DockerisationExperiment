using Microsoft.AspNetCore.Mvc;

namespace DockerTest.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet]
        public Task<string[]> GetItems()
        {
            return Task.FromResult(new[] { "here's a thing", "and another" });
        }
    }
}
