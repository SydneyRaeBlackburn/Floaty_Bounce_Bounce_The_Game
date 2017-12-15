using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void ClickAction(int scene);
    public static event ClickAction OnClicked;

    void changeScene(int scene)
    {
        if (OnClicked != null)
            OnClicked(scene);
    }
}
