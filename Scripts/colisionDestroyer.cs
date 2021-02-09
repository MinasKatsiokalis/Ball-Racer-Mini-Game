using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colisionDestroyer : MonoBehaviour {
	public GameObject[] balls;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision other)
	{
		Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "player_ball") {
			Destroy(other.gameObject);
			Time.timeScale = 0;

		}
		else if(other.gameObject.name == "Enemy ball"){
			for (int i = 0; i < balls.Length; i++) {
				if (balls[i] != null) {
					if (balls[i].GetComponent<EnemiesActions>().score > other.gameObject.GetComponent<EnemiesActions>().score) {
						balls[i].GetComponent<EnemiesActions>().score = balls [i].GetComponent<EnemiesActions> ().score-1;
					}
				}
			}
			if (player.GetComponent<PlayerActions>().score > other.gameObject.GetComponent<EnemiesActions>().score) {
				player.GetComponent<PlayerActions>().score = player.GetComponent<PlayerActions> ().score-1;
			}
			Destroy(other.gameObject.transform.parent.gameObject);
		}
	}

}
