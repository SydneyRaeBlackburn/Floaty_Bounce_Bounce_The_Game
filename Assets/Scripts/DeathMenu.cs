using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{

    public GameObject go;
    public GameManager gm;

    public Text score;
    public Text playButton;
    public Text lives;

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
        lives.text = "Lives: " + ((int)gm.lives).ToString();
        if (gm.lives <= 0)
            playButton.text = "Play Again";
        else
            playButton.text = "Continue?";
    }

    public void ToggleDeathMenu()
    {
        if (gm.isDead)
            gameObject.SetActive(true);
    }

}
