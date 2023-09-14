using MVP.SlotMachine.Models.Core;
using UnityEngine;

namespace MVP.SlotMachine.Presenters.Core
{
    public abstract class Presenter
    {
        protected readonly Model _model;

        public Presenter(Model model)
        {
            _model = model;
        }

        public void OnSpinButtonClicked()
        {
            if (_model.CanSpin())
            {
                Spin();
            }
        }

        public void OnSlotClicked(int slotId)
        {
            ReRollSlot(slotId);
        }

        private void Spin()
        {
            var currentState = _model.State;
            for (int i = 0; i < _model.State.Count; i++)
            {
                currentState[i] = Random.Range(0, 6);
            }

            _model.SetState(currentState);
            _model.SetWinState(AnalyzeResult());
        }

        private void ReRollSlot(int slotId)
        {
            var currentState = _model.State;
            var slotValue = Random.Range(0, 6);
            currentState[slotId] = slotValue;

            _model.SetState(currentState);
            _model.SetWinState(AnalyzeResult());
        }

        protected abstract bool AnalyzeResult();
    }
}
