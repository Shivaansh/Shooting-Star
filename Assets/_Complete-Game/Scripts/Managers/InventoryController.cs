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

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                canvas.enabled = !canvas.enabled;
                Pause();
            }
        }

        public void Pause()
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
            Lowpass();

        }

        void Lowpass()
        {
            if (Time.timeScale == 0)
            {
                paused.TransitionTo(.01f);
            }

            else

            {
                unpaused.TransitionTo(.01f);
            }
        }
    }
}