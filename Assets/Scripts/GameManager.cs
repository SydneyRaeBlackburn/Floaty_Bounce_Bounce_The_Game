﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;

	public float score = 0.0f;
	public float playerSpeed = 0.0f;
	public boolean isDead = false;

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
}
