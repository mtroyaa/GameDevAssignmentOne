//ScoreManager.cs
//Michael Troya
//Controls Games Points


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score;

	Text text;

//start score at 0

	void Start()
	{

		text = GetComponent<Text> ();

		score = 0;

	}

	void Update(){
	
		if (score < 0)
			score = 0;

		text.text = "" + score;

		}


	//adds points to gui

	public static void AddPoints (int pointsToAdd){
	
		score += pointsToAdd;
	
	}

	//reset points if needed

	public static void Reset(){

		score = 0;
	}
}



