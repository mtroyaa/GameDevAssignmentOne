//HurtPlayer.cs
//Michael Troya
//Controls When A PLayer is hurt by enemy

using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {

	public int damageToGive;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//checks when player runs into enemies and plays sound
	void OnTriggerEnter2D(Collider2D other){


		if (other.name == "Player") {

			HealthManager.hurtPlayer (damageToGive);
			other.GetComponent<AudioSource> ().Play ();

		}


	}
}
