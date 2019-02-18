using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalRules : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectsWithTag("Targetable").Length == 0)
        {
            print("There are no Targetable objects");
        }
        for (int i = 0; i == GameObject.FindGameObjectsWithTag("Targetable").Length; i++)
        {
            GameObject.FindGameObjectsWithTag("Targetable")[i].AddComponent<TestScript>();
            print("Script added");
        }
    }

    // Update is called once per frame
    void Update() {
        
	}
}
