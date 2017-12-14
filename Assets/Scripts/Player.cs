using System.Collections;
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
	}
	
	// Update is called once per frame
	void Update () {

        if (gm.isDead)
            return;

        moveVector = Vector3.zero;

        moveVector.x = Input.GetAxisRaw("Horizontal") * gm.playerSpeed;
        moveVector.y = Input.GetAxisRaw("Vertical") * gm.playerSpeed;
        moveVector.z = gm.playerSpeed;

        controller.Move(moveVector * Time.deltaTime);
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.point.z > transform.position.z + controller.radius)
        {
            Death();
            //sounds.PlayOneShot(crash);
        }
    }

    private void Death()
    {
        Debug.Log("Deadddd");
        gm.isDead = true;
    }
}
