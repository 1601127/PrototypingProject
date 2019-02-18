using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float XAngle;
    private float YAngle;

    public float MovSpeed;
    public float RotSpeed;


	// Use this for initialization
	void Start () {
        MovSpeed = 5;
        RotSpeed = 400;

	}
	
	// Update is called once per frame
	void Update () {
        // Player direction changes with movement of the mouse
        XAngle = Input.GetAxis("Mouse X");
        YAngle = Input.GetAxis("Mouse Y");
        gameObject.transform.Rotate(0, XAngle*RotSpeed*Time.deltaTime, YAngle * RotSpeed * Time.deltaTime);

        // Corrects the players rotation to alight with the world XYZ axis

        if (Input.GetAxis("AutoAlign") > 0)
        {
            gameObject.transform.SetPositionAndRotation(gameObject.transform.position, new Quaternion(0, 0, 0, 0));

        }

        // Moves the player "forward"

        if (Input.GetAxis("MoveForward") > 0)
        {
            gameObject.transform.Translate(MovSpeed * Time.deltaTime, 0, 0);
        }

        
    }
}
