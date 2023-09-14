using MVP.SlotMachine.Models.Core;
using MVP.SlotMachine.Presenters.Core;

namespace MVP.SlotMachine.Presenters
{
    public class AllLinesPresenter : Presenter
    {
        public AllLinesPresenter(Model model) : base(model)
        {
        }

        protected override bool AnalyzeResult()
        {
            var state = _model.State;

            return
                state[0] == state[1] && state[0] == state[2] &&
                state[3] == state[4] && state[3] == state[5] &&
                state[6] == state[7] && state[6] == state[8];
        }
    }
}
