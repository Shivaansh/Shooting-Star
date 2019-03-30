using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GettoDiffi : MonoBehaviour
{
    public void changeToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
