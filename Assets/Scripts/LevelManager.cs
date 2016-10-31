//levelManager.cs
//Michael Troya
//Controls PLayer life and death 


using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public GameObject currentCheckPoint;

	private PLayerController player;

	public GameObject dParticle;
	public GameObject lParticle;

	public float respawnTime;


	public int pointPenatlyOnDeath;

	public HealthManager healthManager;


	// Use this for initialization
	void Start () {

		player = FindObjectOfType<PLayerController> ();

		healthManager = FindObjectOfType <HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer(){

		StartCoroutine("RespawnPlayerCo");

	}

	//coroutine to generalize subroutinens 
	//this method controls what happens during and after player death

	public IEnumerator RespawnPlayerCo(){
	
		Instantiate (dParticle, player.transform.position, player.transform.rotation);

		player.enabled = false;

		player.GetComponent<Renderer>().enabled = false;
		player.GetComponent<Rigidbody2D> ().gravityScale = 0f;

		player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;

		ScoreManager.AddPoints (-pointPenatlyOnDeath);

		yield return new WaitForSeconds (respawnTime);
		player.GetComponent<Rigidbody2D> ().gravityScale = 5;

		player.transform.position = currentCheckPoint.transform.position;

		player.enabled = true;

		player.GetComponent<Renderer>().enabled = true;
		healthManager.FullHealth();
		healthManager.isDead = false;

		Instantiate (lParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
	
	}
}