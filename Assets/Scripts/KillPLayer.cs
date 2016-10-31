//KillPlayer.cs
//Michael Troya
//Controls When a PLayer Dies


using UnityEngine;
using System.Collections;

public class KillPLayer : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {

		levelManager = FindObjectOfType<LevelManager> ();

	}
	// Update is called once per frame
	void Update () {
			

	}


	//calls level manager to kill player and respawn
	void OnTriggerEnter2D(Collider2D other){
	
	
		if (other.name == "Player") {
		
			levelManager.RespawnPlayer ();
		
		
		}

	
	}



}
