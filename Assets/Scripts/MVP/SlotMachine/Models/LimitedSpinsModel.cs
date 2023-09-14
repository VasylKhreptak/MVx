using MVP.SlotMachine.Models.Core;
using MVP.SlotMachine.Views.Core;

namespace MVP.SlotMachine.Models
{
    public class LimitedSpinsModel : Model
    {
        private readonly int _maxSpins;

        public LimitedSpinsModel(View view, int maxSpins) : base(view)
        {
            _maxSpins = maxSpins;
        }

        public override bool CanSpin() => SpinsCount < _maxSpins;
    }
}
