using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace CompleteProject
{
    public class PauseManager : MonoBehaviour
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

        public void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
        }
    }
}
