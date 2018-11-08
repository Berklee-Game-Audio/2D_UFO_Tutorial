//Unity 2D UFO Tutorial from 
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
//updated to Unity 2018.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add the Canvas namespace
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	//used to control the player's speed
	public float speed;

	//use a public variable to display the count
	public Text countText;

	public Text winText;

	//we need a Rigidbody for the physics system to work with
	private Rigidbody2D rb2d;

	//a place to hold the number of pickups we have triggered
	private int count;

	private void Start()
	{
		//we associate the component on the current object to the Rigidbody2D variable
		rb2d = GetComponent<Rigidbody2D>();

		//initialize count to zero when the scene is loaded
		count = 0;

		//set a blank message to start the game
		winText.text = " ";

		//set the text display to the current value of count
		SetCountText();
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

	private void OnTriggerEnter2D(Collider2D other)
	{
		//check to see if we collided with a Pickup
		if (other.gameObject.CompareTag("PickUp"))
		{
			//disable the pickups once they are collided with
			other.gameObject.SetActive (false);

			//increment the count variable
			count = count + 1;

			//update the Counttext UI element
			SetCountText();		
		}
	}

	void SetCountText () 
	{
		//send the count value to the displayed text UI element
		countText.text = "Count: " + count.ToString();

		//check to see if all of the pickups have been collected
		//if they have, display a message
		if (count >= 12)
		{
			winText.text = "You Win!!!";
		}
	
	}
}
