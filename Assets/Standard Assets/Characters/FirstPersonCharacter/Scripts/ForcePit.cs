/*
 * Jacob Buri
 * ForcePit.cs
 * Assignment 9
 * Trigger to apply force upwards
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePit : MonoBehaviour
{
	public float liftForce = 10f;

    void OnTriggerStay(Collider other)
    {
		other.attachedRigidbody.AddForce(Vector3.up * liftForce, ForceMode.Force);
    }
}
