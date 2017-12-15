using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.OnClicked += LoadByIndex;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= LoadByIndex;
    }

    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}