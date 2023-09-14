using System.Collections.Generic;
using MVC.SlotMachine.Controllers.Core;
using MVC.SlotMachine.Models.Core;

namespace MVC.SlotMachine.Controllers
{
    public class MiddleLineController : Controller
    {
        public MiddleLineController(Model model) : base(model)
        {

        }


        protected override bool AnalyzeWinResult(List<int> state)
        {
            return state[3] == state[4] && state[3] == state[5];
        }
    }
}
