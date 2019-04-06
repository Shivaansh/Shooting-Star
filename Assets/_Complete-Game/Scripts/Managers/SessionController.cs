using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

namespace CompleteProject
{
    public class SessionController: MonoBehaviour

    {
        public AudioMixerSnapshot paused;
        public AudioMixerSnapshot unpaused;

        public int pauseState = 0;

        public PauseManager p;
        public InventoryController inv;
        

        Canvas canvas;

        void Start()
        {
            canvas = GetComponent<Canvas>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (pauseState == 0)
                {
                    pauseState += 1;
                    canvas.enabled = !canvas.enabled;
                    Pause();
                }
                else if (pauseState == 1 && canvas.enabled == true)
                {
                    pauseState -= 1;
                    canvas.enabled = !canvas.enabled;
                    Pause();

                }
                else if(canvas.enabled == false)
                {
                    pauseState += 1;
                    canvas.enabled = !canvas.enabled;
                }
                else if(canvas.enabled == true)
                {
                    pauseState -= 1;
                    canvas.enabled = !canvas.enabled;
                }
                
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pauseState == 0)
                {
                    pauseState += 1;
                    p.changeVisibility();
                    Pause();
                }
                else if (pauseState == 1 && p.isShown() == true)
                {
                    pauseState -= 1;
                    p.changeVisibility();
                    Pause();

                }
                else if (p.isShown() == false)
                {
                    pauseState += 1;
                    p.changeVisibility();
                }
                else if (p.isShown() == true)
                {
                    pauseState -= 1;
                    p.changeVisibility();
                }
                
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                if (pauseState == 0)
                {
                    pauseState += 1;
                    inv.changeVisibility();
                    Pause();
                }
                else if (pauseState == 1 && inv.isShown() == true)
                {
                    pauseState -= 1;
                    inv.changeVisibility();
                    Pause();

                }
                else if (inv.isShown() == false)
                {
                    pauseState += 1;
                    inv.changeVisibility();
                }
                else if (inv.isShown() == true)
                {
                    pauseState -= 1;
                    inv.changeVisibility();
                }

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