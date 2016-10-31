//DestroyFinishedParticle.cs
//Michael Troya
//Controls Particles so they dont have an endless loop


using UnityEngine;
using System.Collections;

public class DestroyFinishedParticle : MonoBehaviour {

	private ParticleSystem thisParticleSystem;



	// Use this for initialization
	void Start () {


		thisParticleSystem = GetComponent<ParticleSystem>();
	}

	//desroys partuicles after playing 
	// Update is called once per frame
	void Update () {

		if (thisParticleSystem.isPlaying)
			return;

		Destroy (gameObject);
	}
}
