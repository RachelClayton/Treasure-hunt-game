﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.Space) ) {

			SceneManager.LoadScene (1);
		}
	} 
} 