using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    public Image splashImage;
    public string loadScene;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(loadScene);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 2.0f, false);
    }
}
