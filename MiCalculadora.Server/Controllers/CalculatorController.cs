using Microsoft.AspNetCore.Mvc;

namespace MiCalculadora.Server.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet("{num1}/{num2}")]
        public decimal operacion(decimal num1,decimal num2, string pOperacion)
        {
            var resultado = 0;

            switch (pOperacion)
            {
                case "resta":
                    resultado= 
                    break;
            }
            



            return resultado;

        }
    }
}
