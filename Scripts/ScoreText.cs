using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
	public GameObject this_AI;
	public GameObject txt;
	private Text scoreText; 
	// Use this for initialization
	void Start () {
		scoreText = txt.GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if (this_AI.GetComponent<EnemiesActions> ().score == 1) {
			scoreText.text = "" + this_AI.GetComponent<EnemiesActions> ().score + "st";
		} 
		else if (this_AI.GetComponent<EnemiesActions> ().score == 2) {
			scoreText.text = "" + this_AI.GetComponent<EnemiesActions> ().score + "nd";
		} 
		else if (this_AI.GetComponent<EnemiesActions> ().score == 3) {
			scoreText.text = "" + this_AI.GetComponent<EnemiesActions> ().score + "rd";
		} 
		else {
			scoreText.text = "" + this_AI.GetComponent<EnemiesActions> ().score + "th";
		}
	}
}
