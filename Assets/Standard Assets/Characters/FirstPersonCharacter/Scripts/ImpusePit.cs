/*
 * Jacob Buri
 * ImpusePit.cs
 * Assignment 9
 * Trigger to apply impuse upwards
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpusePit : MonoBehaviour
{
	public float liftForce = 10f;

	void OnTriggerEnter(Collider other)
	{
		other.attachedRigidbody.AddForce(Vector3.up * liftForce, ForceMode.Impulse);
	}
}
