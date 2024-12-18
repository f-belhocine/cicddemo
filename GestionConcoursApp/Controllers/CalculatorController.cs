using Microsoft.AspNetCore.Mvc;

namespace GestionConcoursApp.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
