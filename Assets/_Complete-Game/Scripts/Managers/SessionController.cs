using UnityEditor;
using UnityEngine;

namespace CompleteProject
{
    public class SessionController: MonoBehaviour

    {
    Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled;
        }
    }

  
    public void Quit()
    {
        //EditorApplication.isPlaying = false;

		Application.Quit();

    }
    }
}