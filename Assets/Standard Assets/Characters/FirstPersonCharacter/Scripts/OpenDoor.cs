/*
 * Jacob Buri
 * OpenDoor.cs
 * Assignment 9
 * Uses Raycasting to open the door instead of colliders
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	void Update()
	{
		// Bit shift the index of the layer (8) to get a bit mask
		//Created custom layer "Player" as layer 8
		int layerMask = 1 << 8;

		RaycastHit hit;
		// Does the ray intersect any objects
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log("Did Hit");
		}
		else
		{
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
			Debug.Log("Did not Hit");
		}
	}
}
