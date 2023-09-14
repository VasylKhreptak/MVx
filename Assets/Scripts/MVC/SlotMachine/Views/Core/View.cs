using System.Collections.Generic;
using UnityEngine;

namespace MVC.SlotMachine.Views.Core
{
    public abstract class View : MonoBehaviour
    {
        public abstract void DisplaySpinResult(List<int> values);
        public abstract void DisplayYouWinText(bool isActive);
    }
}
