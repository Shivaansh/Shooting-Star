using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadRooms : MonoBehaviour
{
    public void changeToScene(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }
}

