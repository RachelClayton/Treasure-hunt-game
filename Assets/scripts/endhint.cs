using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class endhint : MonoBehaviour {
	Collider2D box;
	public GameObject player;
	Collider2D playerbox;
	public Text UItext;

	// Use this for initialization
	void Start () {
		box = GetComponent<Collider2D> ();
		playerbox = player.GetComponent<Collider2D> ();


	}

	// Update is called once per frame
	void Update () {
		if (playerbox.IsTouching (box)) {
			UItext.text = " ";
		}


	}

}
