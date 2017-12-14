using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public GameObject go;
    public GameManager gm;

    private int difficulty = 1;
    private int maxDifficulty = 10;
    private int scoreToNextLevel = 10;

    public Text score;
    public DeathMenu deathMenu;

    private void Awake()
    {
        go = GameObject.FindGameObjectWithTag("GameController");
        gm = go.GetComponent<GameManager>();
    }

    // Use this for initialization
    void Start()
    {
        gm.ResetScore();
        gm.ResetSpeed();
        gm.ResetDeath();
    }

    // Update is called once per frame
    void Update()
    {

        if (gm.isDead)
        {
            deathMenu.ToggleDeathMenu();
            return;
        }

        if (gm.score >= scoreToNextLevel)
            LevelUp();

        gm.score += Time.deltaTime * difficulty;
        score.text = ((int)gm.score).ToString();
    }

    void LevelUp()
    {
        if (difficulty == maxDifficulty)
            return;
        scoreToNextLevel *= 2;
        difficulty++;
        gm.AddSpeed(difficulty);
    }
}
