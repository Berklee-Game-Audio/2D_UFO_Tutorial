//Unity 2D UFO Tutorial from 
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
//updated to Unity 2018.2
//This is an extension of the tutorial project, that adds in a High Scores table


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//used to restart the game
	bool restart = false;

	public GameObject playCanvas;
	public GameObject loseCanvas;
	
	// Update is called once per frame
	void Update () {
		if (restart) 
		{
			loseCanvas.SetActive(true);
			playCanvas.SetActive(false);
		}
		else{
			playCanvas.SetActive(true);
			loseCanvas.SetActive(false);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Debug.Log("You lost!");
			LoseGame();
		}
	}

	void LoseGame()
	{
		Debug.Log("LoseGame called!");

		//reload the scene when the player loses
		restart = true;
	}
}
