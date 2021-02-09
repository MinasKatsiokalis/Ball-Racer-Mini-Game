using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextPlayer : MonoBehaviour {
	public GameObject this_AI;
	public GameObject txt;
	private Text scoreText; 
	// Use this for initialization
	void Start () {
		scoreText = txt.GetComponent<Text>(); 
	}

	// Update is called once per frame
	void Update () {
		if (this_AI.GetComponent<PlayerActions>().score == 1) {
			scoreText.text = "Your Position: " + this_AI.GetComponent<PlayerActions> ().score + "st"+"\nYour Score:"+(int)((-this_AI.gameObject.transform.position.x+7)*1000f);
		} 
		else if (this_AI.GetComponent<PlayerActions>().score == 2) {
			scoreText.text = "Your Position: " + this_AI.GetComponent<PlayerActions> ().score + "nd"+"\nYour Score:"+(int)((-this_AI.gameObject.transform.position.x+7)*1000f);
		} 
		else if (this_AI.GetComponent<PlayerActions>().score == 3) {
			scoreText.text = "Your Position: " + this_AI.GetComponent<PlayerActions> ().score + "rd"+"\nYour Score:"+(int)((-this_AI.gameObject.transform.position.x+7)*1000f);
		} 
		else {
			scoreText.text = "Your Position: " + this_AI.GetComponent<PlayerActions> ().score + "th"+"\nYour Score:"+(int)((-this_AI.gameObject.transform.position.x+7)*1000f);
		}
	}
}
