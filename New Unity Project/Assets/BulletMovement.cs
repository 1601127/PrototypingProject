using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    private float timer;
    public float time_goal;
	// Use this for initialization
	void Start () {

        //Establishing the required variables
        timer = 0;
        gameObject.tag = "Bullet";
	}
	
	// Update is called once per frame
	void Update () {

        // Moves the bullet in a straight line
        gameObject.transform.Translate(5, 0, 0);

        // Timer used to destroy the bullet after a certain amount of time.
        timer = timer + Time.deltaTime;
        if (timer >= time_goal)
        {
            Destroy(gameObject);
        }
	}
}
