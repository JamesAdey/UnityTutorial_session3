using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{

	public Vector3 startPos = Vector3.back;
	public Vector3 endPos = Vector3.forward;
	private Vector3 initialPos;
	public float duration = 3;

	private Transform thisTransform = null;

	// Use this for initialization
	void Start ()
	{
		thisTransform = this.GetComponent<Transform> ();
		initialPos = thisTransform.position;
	}

	void OnDrawGizmos ()
	{
		Vector3 actualStart = transform.position + startPos;
		Vector3 actualEnd = transform.position + endPos;

		Gizmos.color = Color.red;
		Gizmos.DrawLine (actualStart, actualEnd);
	}

	// Update is called once per frame
	void Update ()
	{

		Vector3 actualStart = initialPos + startPos;
		Vector3 actualEnd = initialPos + endPos;
		float amount = Mathf.PingPong (Time.time / duration, 1);
		thisTransform.position = Vector3.Lerp (actualStart, actualEnd, amount);
	}
}
