using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBox : MonoBehaviour {

	public float maxR;
	public float maxL;
	bool toRight;
	bool toLeft;
	public float speed;

	// Use this for initialization
	void Start () {
		toRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (0, 0, speed);
		if (transform.position.z >= maxR) {
			toLeft = true;
			toRight = false;
		}

		if (transform.position.z <= maxL) {
			toLeft = false;
			toRight = true;
		}

		if (toRight) {
			transform.position += move * Time.deltaTime;
		} else if (toLeft) {
			transform.position -= move * Time.deltaTime;
		}	
	}
}
