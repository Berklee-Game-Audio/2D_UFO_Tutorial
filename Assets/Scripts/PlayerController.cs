//Unity 2D UFO Tutorial from 
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
//updated to Unity 2018.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//used to control the player's speed
	public float speed;

	//we need a Rigidbody for the physics system to work with
	private Rigidbody2D rb2d;


	private void Start()
	{
		//we associate the component on the current object to the Rigidbody2D variable
		rb2d = GetComponent<Rigidbody2D>();
	}

	//please see the decription for FixedUpdate from the Unity manual at
	//https://docs.unity3d.com/Manual/ExecutionOrder.html

	void FixedUpdate () {

		//capture keyboard input Left and Right arrows
		float moveHorizontal = Input.GetAxis("Horizontal");
		//capture keyboard input Up and Down arrows
		float moveVertical = Input.GetAxis("Vertical");

		// create a Vector2 from the user keyboard entry
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		//move the player object with the 2D physics engine multplying by the speed factor
		rb2d.AddForce(movement*speed);
	}
}
