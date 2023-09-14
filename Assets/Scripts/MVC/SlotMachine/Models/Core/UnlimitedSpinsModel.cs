using MVC.SlotMachine.Views.Core;

namespace MVC.SlotMachine.Models.Core
{
    public class UnlimitedSpinsModel : Model
    {
        public UnlimitedSpinsModel(View view) : base(view)
        {
        }

        public override bool CanSpin() => true;
    }
}
