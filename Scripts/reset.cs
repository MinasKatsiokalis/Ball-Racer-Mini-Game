using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour {
	public float pause;
	private Scene scene;
	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene();
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Home)) {
			if(Time.timeScale == 0){
				Time.timeScale = 1;
			}
			SceneManager.LoadScene(scene.name);
		}

		if(Input.GetKeyDown (KeyCode.Escape)){
			Application.Quit();	
		}
	}
}
