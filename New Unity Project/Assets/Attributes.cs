using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour {

    public float Mass;
    private MeshFilter mesh;
	// Use this for initialization
	void Start () {
        mesh = gameObject.GetComponent <MeshFilter> ();
    }
	
	// Update is called once per frame
	void Update () {
		if((gameObject.transform.localScale.x * gameObject.transform.localScale.y * gameObject.transform.localScale.z) != Mass)
        {
            Mass= gameObject.transform.localScale.x * gameObject.transform.localScale.y * gameObject.transform.localScale.z;
        }
	}
}
