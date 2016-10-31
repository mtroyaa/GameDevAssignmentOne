//CheckPoint.cs
//Michael Troya
//Controls Game Checkpoints


using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {
	
	public LevelManager levelManager;

	// Use this for initialization
	void Start () {

		levelManager = FindObjectOfType<LevelManager>();

	}
	// Update is called once per frame
	void Update () {
	
	}


	//when the player runs into checkpoint its makes the player spawn on last checkpoint

	void OnTriggerEnter2D(Collider2D other){


		if (other.name == "Player") {

			levelManager.currentCheckPoint = gameObject;


		}


	}
}
