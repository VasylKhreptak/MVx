using MVP.SlotMachine.Models.Core;
using MVP.SlotMachine.Views.Core;

namespace MVP.SlotMachine.Models
{
    public class UnlimitedSpinsModel : Model
    {
        public UnlimitedSpinsModel(View view) : base(view)
        {
        }

        public override bool CanSpin() => true;
    }
}
