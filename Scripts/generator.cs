using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {
	public GameObject stage;
	private Vector3 stagePos;

	private void Start(){
		//Debug.Log("Creating stage");
		stagePos = stage.transform.position;
		stagePos = new Vector3(stagePos.x-62, stagePos.y, stagePos.z);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "player_ball") {
			Debug.Log("Creating stage");
			Instantiate (stage,stagePos,Quaternion.identity);
		}
	}
}
