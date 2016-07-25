﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
          // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 5f ) {
			didPlayerWin = true; 
			Debug.Log ("player can win"); 
		}

		if ( didPlayerWin == true && Input.GetKeyDown (KeyCode.Space) )  {
			SceneManager.LoadScene (2);
		}
	} 
}
