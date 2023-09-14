using System.Collections.Generic;
using MVP.SlotMachine.Presenters.Core;
using UnityEngine;

namespace MVP.SlotMachine.Views.Core
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter _presenter;

        public void Initialize(Presenter presenter)
        {
            _presenter = presenter;
        }
        
        public abstract void DisplaySpinResult(List<int> values);
        public abstract void DisplayYouWinText(bool enabled);
    }
}
