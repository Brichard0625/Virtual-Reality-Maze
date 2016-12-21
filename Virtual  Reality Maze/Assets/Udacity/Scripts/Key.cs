using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab, keyCollected, AudioClip.*keyCollected should be static variable*
	public GameObject keyPoof;
	public AudioClip clip;
	public static bool keyCollected;

	void Update()
	{
		

	}

	public void OnKeyClicked()
	{
		//Once key has been clicked.  Set keyCollected = true
		keyCollected = true;

		// Instatiate the KeyPoof Prefab where this key is located 
		Instantiate(keyPoof, transform.position, Quaternion.Euler (-90, 0, 0));

		//Play audio once the key is collected
		AudioSource.PlayClipAtPoint(clip, transform.position);

		//Destroy the key when clicked		
		Destroy (gameObject);

			}
}

