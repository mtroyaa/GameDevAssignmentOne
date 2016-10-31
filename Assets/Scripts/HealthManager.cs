//HealthManager.cs
//Michael Troya
//Controls The players health


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {


	public int maxPlayerHealth;
	public static int playerHealth;

	Text text;

	private LevelManager levelManager;

	public bool isDead;

	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();

		playerHealth = maxPlayerHealth;

		levelManager = FindObjectOfType<LevelManager> ();

		isDead = false;


	
	}

	//checks if player is dead and updates health
	
	// Update is called once per frame
	void Update () {

		if (playerHealth <= 0 && !isDead) {

			playerHealth = 0;
			levelManager.RespawnPlayer ();
			isDead = true;
		}

		text.text = "" + playerHealth;
	
	}

	//how much dmaage does the player take
	public static void hurtPlayer(int damageToGive){

		playerHealth -= damageToGive;


	}

	//used if you want to make players health full
	public void FullHealth(){
	
		playerHealth = maxPlayerHealth;
	
	}
}
