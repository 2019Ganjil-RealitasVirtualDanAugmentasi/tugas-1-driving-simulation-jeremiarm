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
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
		if (Input.GetKey("down"))
		{
			transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey("left"))
		{
			if (Input.GetKey("up")){
				transform.Rotate(0,-1,0);
			}
			if (Input.GetKey("down")){
				transform.Rotate(0,-1,0);
			}
		}
		if (Input.GetKey("right"))
		{
			if (Input.GetKey("up")){
				transform.Rotate(0,1,0);
			}
			if (Input.GetKey("down")){
				transform.Rotate(0,1,0);
			}
		}
    }
}
