//Unity 2D UFO Tutorial from 
//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
//updated to Unity 2018.2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);	
	}
}
