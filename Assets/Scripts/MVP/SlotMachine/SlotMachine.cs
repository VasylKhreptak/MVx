using MVP.SlotMachine.Models;
using MVP.SlotMachine.Models.Core;
using MVP.SlotMachine.Presenters;
using MVP.SlotMachine.Presenters.Core;
using MVP.SlotMachine.Views.Core;
using UnityEngine;

namespace MVP.SlotMachine
{
    public class SlotMachine : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private View _mainView;

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

            Presenter presenter = _middleLineWin
                ? new MiddleLinePresenter(model)
                : new AllLinesPresenter(model);

            _mainView.Initialize(presenter);
        }

        #endregion
    }
}
