using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public int damage = 1; 


	//function that is automat called when something w/ a rgidbody enters this trigger
	void OnCollisionEnter2D( Collision2D activator ) {
		if ( activator.gameObject.GetComponent<Killable>() != null ) { //is the thing killable?
			//potential todoL subract health from killablescript

			//but for now we destroy
			//Destroy( activator.gameObject ); 

		}
	}

	void OnCollisionStay2D( Collision2D activator ) {
		if ( activator.gameObject.GetComponent<Killable>() != null ) {
			activator.gameObject.GetComponent<Killable>().Hurt( damage ); 
		} 
}
}
