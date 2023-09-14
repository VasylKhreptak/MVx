using System.Collections.Generic;
using System.Linq;
using MVP.SlotMachine.Views.Core;

namespace MVP.SlotMachine.Models.Core
{
    public abstract class Model
    {
        protected readonly View _view;

        protected List<int> _state;

        public int SpinsCount;

        public List<int> State => _state;

        public bool HasWinState { get; protected set; }

        public Model(View view)
        {
            _view = view;
            _state = new int[9].ToList();
        }

        public void SetState(List<int> newState)
        {
            _state = newState;
            _view.DisplaySpinResult(_state);
        }

        public void SetWinState(bool isWin)
        {
            HasWinState = isWin;
            _view.DisplayYouWinText(HasWinState);
        }

        public abstract bool CanSpin();
    }
}
