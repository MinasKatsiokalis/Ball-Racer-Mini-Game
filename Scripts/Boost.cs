using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour {
	public float boost_force;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		rb = other.gameObject.GetComponent<Rigidbody>();
		if (other.gameObject.name == "player_ball" || other.gameObject.name == "Enemy ball") {
			rb.AddForce (Vector3.left * Time.deltaTime * boost_force);
		}
	}
}
