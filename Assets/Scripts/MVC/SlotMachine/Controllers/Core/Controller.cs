using System.Collections.Generic;
using System.Linq;
using MVC.SlotMachine.Models.Core;
using UnityEngine;

namespace MVC.SlotMachine.Controllers.Core
{
    public abstract class Controller
    {
        protected readonly Model _model;

        public Controller(Model model)
        {
            _model = model;
        }

        public void Spin()
        {
            if (_model.CanSpin() == false) return;

            List<int> state = new int[_model.State.Count].ToList();

            for (int i = 0; i < _model.State.Count; i++)
            {
                state[i] = Random.Range(0, 6);
            }

            _model.SetState(state);
            _model.SetWinState(AnalyzeWinResult(state));
            _model.SpinsCount++;
        }

        protected abstract bool AnalyzeWinResult(List<int> state);
    }
}
