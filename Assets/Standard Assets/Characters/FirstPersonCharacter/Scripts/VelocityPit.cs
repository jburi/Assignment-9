/*
 * Jacob Buri
 * VelocityPit.cs
 * Assignment 9
 * Trigger to apply velocity upwards
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPit : MonoBehaviour
{
	public float liftForce = 10f;

	void OnTriggerEnter(Collider other)
	{
		other.attachedRigidbody.AddForce(Vector3.up * liftForce, ForceMode.VelocityChange);
	}
}
