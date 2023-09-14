using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVC.SlotMachine.Views.Core
{
    public class FlatView : View
    {
        [Header("References")]
        [SerializeField] private List<Image> _images;
        [SerializeField] private List<Color> _colors;
        [SerializeField] private TMP_Text _winText;

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
    }
}
