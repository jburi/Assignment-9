/*
 * Jacob Buri
 * AccelerationPit.cs
 * Assignment 9
 * Trigger to apply acceleration upwards
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationPit : MonoBehaviour
{
	public float liftForce = 10f;

	void OnTriggerStay(Collider other)
	{
		other.attachedRigidbody.AddForce(Vector3.up * liftForce, ForceMode.Acceleration);
	}
}
