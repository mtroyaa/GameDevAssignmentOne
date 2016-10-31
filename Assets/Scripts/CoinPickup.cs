//CoinPickup.cs
//Michael Troya
//Controls When Player picks up coins


using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;

	public AudioSource coinSoundEffect;


	//checks if player gets coin, also plays sound and then destroys the coin
	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.GetComponent<PLayerController> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);


		coinSoundEffect.Play ();
		Destroy (gameObject);
	}
}
