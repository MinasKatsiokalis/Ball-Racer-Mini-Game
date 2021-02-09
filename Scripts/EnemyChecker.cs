using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChecker : MonoBehaviour { 
	// Use this for initialization
	private int tmp;
	public GameObject ai_player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.name == "player_ball") {
			tmp = ai_player.GetComponent<EnemiesActions>().score;
			ai_player.GetComponent<EnemiesActions>().score = col.gameObject.GetComponent<PlayerActions>().score ;
			col.gameObject.GetComponent<PlayerActions>().score = tmp;
		}	
		else if (col.gameObject.name == "Enemy ball" ) {
			tmp = ai_player.GetComponent<EnemiesActions>().score;
			if (ai_player.GetComponent<EnemiesActions> ().score < col.gameObject.GetComponent<EnemiesActions> ().score) {
				ai_player.GetComponent<EnemiesActions> ().score = col.gameObject.GetComponent<EnemiesActions> ().score;
				col.gameObject.GetComponent<EnemiesActions>().score = tmp;
			}
		}	
	}
}
