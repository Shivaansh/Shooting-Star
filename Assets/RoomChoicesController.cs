using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RoomChoicesController : MonoBehaviour
{
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    Canvas canvas;

    void Start()
    {
        canvas = GameObject.Find("RoomChoicesCanvas").GetComponent<Canvas>();
    }


    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        canvas.enabled = !canvas.enabled;
        Pause();
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


    //void OnGUI()
    //{
    //    DrawInfo();
    //}
}
