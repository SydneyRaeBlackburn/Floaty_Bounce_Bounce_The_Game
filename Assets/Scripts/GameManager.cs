using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;

	public float score = 0.0f;
	public float playerSpeed = 15.0f;
	public bool isDead = false;
    public float lives = 3.0f;

	public static GameManager Instance {
		get { return _instance; }
	}

	private void Awake() {
		if( (_instance != null) && (_instance != this))
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
	}

    //Set Player Speed at Level Up
    public void AddSpeed(int modifier)
    {
        playerSpeed += 5.0f * modifier;
    }

    public void ResetScore()
    {
        score = 0.0f;
    }

    public void ResetDeath()
    {
        isDead = false;
    }

    public void ResetSpeed()
    {
        playerSpeed = 15.0f;
    }

    public void ResetLives()
    {
        lives = 3.0f;
    }
}
