using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

	public string replayGame;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetKeyDown(KeyCode.Space))
		{


			Application.LoadLevel(replayGame);
		}
	}
}
