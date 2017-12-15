using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left"))
        {
            anim.Play("flyL");
        }

        if (Input.GetKeyUp("left"))
        {
            anim.Play("flybL");
        }

        if (Input.GetKeyDown("right"))
        {
            anim.Play("flyR");
        }

        if (Input.GetKeyUp("right"))
        {
            anim.Play("flybR");
        }

        if (Input.GetKeyDown("up"))
        {
            anim.Play("flyU");
        }

        if (Input.GetKeyUp("up"))
        {
            anim.Play("flybU");
        }
    }
}
