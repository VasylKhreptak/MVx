using MVC.SlotMachine.Models.Core;
using MVC.SlotMachine.Views.Core;

namespace MVC.SlotMachine.Models
{
    public class UnlimitedSpinsModel : Model
    {
        public UnlimitedSpinsModel(View view) : base(view)
        {
        }

        public override bool CanSpin() => true;
    }
}
