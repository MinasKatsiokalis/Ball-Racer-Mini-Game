using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoad : MonoBehaviour {

	public void startGameRacer()
	{
		SceneManager.LoadScene("GameRacer");
	}

	public void quitGameRacer()
	{
		Application.Quit();	
	}

}	

