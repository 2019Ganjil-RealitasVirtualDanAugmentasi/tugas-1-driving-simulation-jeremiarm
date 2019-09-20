using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float movementSpeed = 10;

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * -1 * movementSpeed * Time.deltaTime);
        }
            
    }
}
