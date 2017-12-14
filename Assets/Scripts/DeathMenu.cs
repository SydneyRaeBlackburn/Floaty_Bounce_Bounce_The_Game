using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{

    public GameObject go;
    public GameManager gm;

    public Text score;

    private void Awake()
    {
        go = GameObject.FindGameObjectWithTag("GameController");
        gm = go.GetComponent<GameManager>();
    }

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ((int)gm.score).ToString();
    }

    public void ToggleDeathMenu()
    {
        if (gm.isDead)
            gameObject.SetActive(true);
    }

}
