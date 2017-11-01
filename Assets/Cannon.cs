using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
	public GameObject projectile = null;
	public Transform firePoint = null;

	public int launchSpeed = 10;
	public float fireTime = 1f;

	private float nextFireTime = 0f;
	
	// Update is called once per frame
	void Update ()
	{
		// are we later than the next time to shoot at?
		if (Time.time >= nextFireTime) {
			// shoot!
			LaunchProjectile ();
			// set the next time to shoot at
			nextFireTime = Time.time + fireTime;
		}
	}

	void LaunchProjectile ()
	{
		// create the cannon ball
		GameObject newProj = (GameObject)Instantiate (projectile, firePoint.position, firePoint.rotation);
		// search the cannon ball object for the controlling script
		Cannonball projScript = newProj.GetComponent<Cannonball> ();
		// tell the cannon ball how to fire
		projScript.FireNow (launchSpeed);

	}
}
