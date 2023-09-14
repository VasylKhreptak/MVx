using System.Collections.Generic;
using MVP.SlotMachine.Views.Core;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MVP.SlotMachine.Views
{
    public class FlatView : View
    {
        [Header("References")]
        [SerializeField] private List<Image> _images;
        [SerializeField] private List<Color> _colors;
        [SerializeField] private TMP_Text _winText;
        [SerializeField] private Button _spinButton;

        #region MonoBehaviour

        private void OnEnable()
        {
            _spinButton.onClick.AddListener(_presenter.OnSpinButtonClicked);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                HandleClick();
            }
        }

        private void OnDisable()
        {
            _spinButton.onClick.RemoveListener(_presenter.OnSpinButtonClicked);
        }

        #endregion

        public override void DisplaySpinResult(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                _images[i].color = _colors[values[i]];
            }
        }

        public override void DisplayYouWinText(bool isActive)
        {
            _winText.gameObject.SetActive(isActive);
        }

        private void HandleClick()
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>(1);

            EventSystem.current.RaycastAll(pointerData, results);
            
            if (results.Count > 0)
            {
                if (results[0].gameObject.TryGetComponent(out Slot slot))
                {
                    _presenter.OnSlotClicked(slot.Id);
                }
            }
        }
    }
}
