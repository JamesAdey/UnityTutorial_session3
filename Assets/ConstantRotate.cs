using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotate : MonoBehaviour
{

	public Vector3 axis = Vector3.up;
	public int speed = 90;

	private Transform thisTransform = null;

	// Use this for initialization
	void Start ()
	{
		thisTransform = this.GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		thisTransform.Rotate (axis * speed * Time.deltaTime);
	}
}
