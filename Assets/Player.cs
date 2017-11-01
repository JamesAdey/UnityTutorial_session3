using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth = 100;
	public int respawnHeight = -10;
	public Vector3 respawnPos = Vector3.zero;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (currentHealth <= 0) {
			Respawn ();
		}

		// are we below the respawn height?
		if (transform.position.y < respawnHeight) {
			// call the "Respawn()" function, and respawn ourselves
			Respawn ();
		}
	}

	void Respawn ()
	{
		// set our position back to the respawn position
		transform.position = respawnPos;
		// reset our current health back to maximum
		currentHealth = maxHealth;
	}

	void TakeDamage (int dmg)
	{
		currentHealth = currentHealth - dmg;
	}
}




