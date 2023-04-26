using CalculatorApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public IActionResult Index()
        {
            CalculatorViewModels model = new CalculatorViewModels();

            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorViewModels viewModels)
        {
            switch (viewModels.SelectedOperation)
            {
                case "+":
                    viewModels.Result = viewModels.Operand1 + viewModels.Operand2;
                    break;
               case "-":
                    viewModels.Result = viewModels.Operand1 - viewModels.Operand2;
               break;
                case "*":
                    viewModels.Result = viewModels.Operand1 * viewModels.Operand2;
                    break;
                case "/":
                    viewModels.Result = viewModels.Operand1 / viewModels.Operand2;
                    break;
            }
            return View("Index", viewModels);
        }
    }
}
