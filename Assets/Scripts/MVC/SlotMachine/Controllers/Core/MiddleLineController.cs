using System.Collections.Generic;
using MVC.SlotMachine.Models.Core;

namespace MVC.SlotMachine.Controllers.Core
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
