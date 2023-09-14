using UnityEngine;

namespace MVP.SlotMachine.Views
{
    public class Slot : MonoBehaviour
    {
        [Header("Preferences")]
        [SerializeField] private int _id;

        public int Id => _id;
    }
}
