using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a reference for a locked door and AudioClip
	public bool locked;
	public AudioClip clip;

	void Start(){
		//Set door locked=true upon start of the maze
		locked = true;

		//since keyCollected is static set to false upon start of maze
		Key.keyCollected = false;

	}

		void Update() {
		// Set door to "not(!)locked and animate door to move up along the y-axis
		if (!locked) {
			if (transform.position.y < 24.2f) {
				transform.Translate (0, 11.2f* Time.deltaTime, 0, Space.World);
			}
		}
	}
		

        public void unlock(){
        // Reference the keyCollected from the key.cs and if key is collected set locked to false.
		 if (Key.keyCollected) {
		locked = false;
		
		//Play audio when door is unlocked
		AudioSource.PlayClipAtPoint(clip, transform.position);
				}
				
}
}

