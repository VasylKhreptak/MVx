using System.Collections.Generic;
using MVC.SlotMachine.Controllers.Core;
using MVC.SlotMachine.Models.Core;

namespace MVC.SlotMachine.Controllers
{
    public class AllLinesController : Controller
    {
        public AllLinesController(Model model) : base(model)
        {

        }

        protected override bool AnalyzeWinResult(List<int> state)
        {
            return
                state[0] == state[1] && state[0] == state[2] ||
                state[3] == state[4] && state[3] == state[5] ||
                state[6] == state[7] && state[6] == state[8];
        }
    }
}
