using MVP.SlotMachine.Models.Core;
using MVP.SlotMachine.Presenters.Core;

namespace MVP.SlotMachine.Presenters
{
    public class MiddleLinePresenter : Presenter
    {
        public MiddleLinePresenter(Model model) : base(model)
        {
        }

        protected override bool AnalyzeResult()
        {
            var state = _model.State;

            return state[3] == state[4] && state[3] == state[5];
        }
    }
}
