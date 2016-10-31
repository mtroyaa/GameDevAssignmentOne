//youWin.cs
//Michael Troya
//Checks If PLayer Makes it to the exit and presses correct keys

using UnityEngine;
using System.Collections;

public class youWin : MonoBehaviour {

	private bool playerInZone;

	public string youWinLoad;

	// Use this for initialization
	void Start () {

		playerInZone = false;
	
	}
	
	// Update is called once per frame
	//checks if player is in zone and key is pressed
	void Update () {

		if(Input.GetKeyDown(KeyCode.S) && playerInZone)
		{


			Application.LoadLevel(youWinLoad);
		}
	
	}

	//finds what enters tigger zone
	void OnTriggerEnter2D(Collider2D other){


		if (other.name == "Player") {
		
			playerInZone = true;
		}


	}

	//finds if player leaves trigger zone

	void OnTriggerExit2D(Collider2D other){


		if (other.name == "Player") {

			playerInZone = false;
		}


	}

}
