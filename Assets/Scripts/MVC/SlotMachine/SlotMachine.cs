using MVC.SlotMachine.Controllers.Core;
using MVC.SlotMachine.Models.Core;
using MVC.SlotMachine.Views.Core;
using UnityEngine;
using UnityEngine.UI;

namespace MVC.SlotMachine
{
    public class SlotMachine : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private View _mainView;
        [SerializeField] private Button _spinButton;

        [Header("Preferences")]
        [SerializeField] private int _spinsCount = -1;

        [Header("Win Preferences")]
        [SerializeField] private bool _middleLineWin = true;

        #region MonoBehaviour

        private void Awake()
        {
            Model model = _spinsCount == -1
                ? new UnlimitedSpinsModel(_mainView)
                : new LimitedSpinsModel(_mainView, _spinsCount);

            Controller controller = _middleLineWin
                ? new MiddleLineController(model)
                : new AllLinesController(model);

            _spinButton.onClick.AddListener(controller.Spin);
        }

        #endregion
    }
}
