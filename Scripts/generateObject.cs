using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObject : MonoBehaviour {

	public GameObject[] obj;
	private Vector3 objPos;
	// Use this for initialization
	void Start () {
		int randomInt = Random.Range (0,obj.Length);
		//sDebug.Log (randomInt);
		objPos = this.transform.position;
		Instantiate (obj[randomInt],objPos,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
