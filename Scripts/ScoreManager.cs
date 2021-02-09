using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour {

	public GameObject[] balls;
	public GameObject player;
	private float[] pos;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < balls.Length; i++){
			if (balls [i] != null) {
				pos [i] = -(balls[i].transform.parent.position.x);
			}
		}
		Array.Sort(pos);
		for (int i = 0; i < pos.Length; i++){
			if (pos [i] != null) {
				for (int j=0; j < balls.Length; j++) {
					if (balls [j] != null) {
						if (-(balls [j].transform.parent.position.x) == pos [i]) {
							balls[j].GetComponent<EnemiesActions> ().score = i;
						}
					}
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < balls.Length; i++){

		}
		Array.Sort (pos);
		for (int i = 0; i < pos.Length; i++){
			if (pos [i] != null) {
				for (int j=0; j < balls.Length; j++) {
					if (balls [j] != null) {
						if (-(balls [j].transform.parent.position.x) == pos [i]) {
							balls [j].GetComponent<EnemiesActions> ().score = i;
						}
					}
				}
			}
		}

	}
}
