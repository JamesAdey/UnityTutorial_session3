﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{

	public void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene ("Main_Menu");
		}
	}
}
