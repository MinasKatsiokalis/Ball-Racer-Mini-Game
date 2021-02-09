using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesActions : MonoBehaviour {

	public float movementSpeed;
	public float turnSpeed;
	public float distance;
	public Rigidbody rb;
	public int score;
	public LayerMask myMask;

	// Use this for initialization
	void Start () {
		rb.maxAngularVelocity = 15;
	}
	
	// Update is called once per frame
	void Update () {
		//forward movement
		rb.AddTorque (Vector3.forward * Time.deltaTime * movementSpeed);

		RaycastHit hit;
		Ray obstacleRay = new Ray (transform.position, Vector3.left);

		Debug.DrawRay (transform.position, Vector3.left * distance);

		if (Physics.Raycast (obstacleRay, out hit, distance,myMask)) {
			//Put where you want your ball to move
			if (this.transform.parent.position.z < 0) {				
				rb.AddForce (Vector3.forward * Time.deltaTime * turnSpeed);
			} 
			else if (this.transform.parent.position.z >= 0) {
				rb.AddForce (Vector3.back * Time.deltaTime * turnSpeed);
			}
		}
		
	}
}
