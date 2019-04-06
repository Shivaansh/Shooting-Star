using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

namespace CompleteProject
{
    public class InventoryController : MonoBehaviour

    {
        public AudioMixerSnapshot paused;
        public AudioMixerSnapshot unpaused;

        Canvas canvas;

        void Start()
        {
            canvas = GetComponent<Canvas>();
        }

        public void changeVisibility()
        {
            canvas.enabled = !canvas.enabled;
        }

        public bool isShown()
        {
            return canvas.enabled;
        }

    }
}