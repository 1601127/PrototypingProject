using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3((Input.GetAxis("Horizontal")) * speed *Time.deltaTime, 0, 0);
            gameObject.transform.Rotate((Input.GetAxis("Horizontal") * speed * Time.deltaTime), 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, (Input.GetAxis("Vertical")) * speed * Time.deltaTime,0) ;
        }
        if (Input.GetAxis("Jump") != 0)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, speed * Time.deltaTime, 0);
        }

    }
}
