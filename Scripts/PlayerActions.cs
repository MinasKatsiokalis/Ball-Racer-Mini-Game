using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour {

	public float movementSpeed;
	public float turnSpeed;
	public Rigidbody rb;
	public float distance;

	public int score;

	// Use this for initialization
	void Start () {
		rb.maxAngularVelocity = 15;
	
	}
		
	
	// Update is called once per frame
	void Update () {
	
		//forward movement
		rb.AddTorque (Vector3.forward * Time.deltaTime * movementSpeed);
	
		//turn left/right using mouse
		if (Input.GetKey(KeyCode.RightArrow)) {
			rb.AddForce (Vector3.forward * Time.deltaTime * turnSpeed);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) {
			rb.AddForce (Vector3.back * Time.deltaTime * turnSpeed);
		}
			
	}
		

}