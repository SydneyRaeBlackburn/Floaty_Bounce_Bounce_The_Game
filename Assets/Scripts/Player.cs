﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject go;
	public GameManager gm;

	private CharacterController controller;
	private Vector3 moveVector;

	private void Awake() {
		go = GameObject.FindGameObjectWithTag("GameController");
        gm = go.GetComponent<GameManager>();
	}

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
        sounds = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
