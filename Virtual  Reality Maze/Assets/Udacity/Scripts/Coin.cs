using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coin : MonoBehaviour 
{
	//Reference coin, coinPoof, and AudioClip
	public Coin coin;
	public GameObject coinpoof;
	public AudioClip clip;



	public void OnCoinClicked(){
		// Instantiate coinPoof once a coin is clicked
		Instantiate(coinpoof, transform.position,Quaternion.Euler(-90, 0, 0));

		//play audio once a coin is clicked
		AudioSource.PlayClipAtPoint(clip, transform.position);

		// Destory a coin once its clicked.
		Destroy (gameObject);





	}
}