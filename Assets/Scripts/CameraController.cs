//Unity 2D UFO Tutorial from 
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
//updated to Unity 2018.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//We want our camera to follow the player, so we create a public GameObject
	//variable which we will be able to drag onto in the inspector
	public GameObject player;

	//the offset will provide a constant distance from the camera to the player
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
	}

	// Please see the Unity manual for a description as to how the LateUpdate function works
	//https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html
	/* a follow camera should always be implemented in LateUpdate because 
	 * it tracks objects that might have moved inside Update. */

	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
