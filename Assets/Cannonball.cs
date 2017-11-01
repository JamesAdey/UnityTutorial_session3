using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{

	private Rigidbody thisRigidbody = null;

	public float lifeTime = 10f;
	private float killTime = 0f;

	// Use this for initialization
	void Awake ()
	{
		thisRigidbody = this.GetComponent<Rigidbody> ();
		killTime = Time.time + lifeTime;
	}

	public void FireNow (float speed)
	{
		thisRigidbody.AddRelativeForce (Vector3.forward * speed, ForceMode.VelocityChange);
	}

	public void Update ()
	{
		if (Time.time > killTime) {
			Destroy (gameObject);
		}
	}
}
