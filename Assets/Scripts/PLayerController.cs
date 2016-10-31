//PlayerController.cs
//Michael Troya
//Controls the games player avatar


using UnityEngine;
using System.Collections;

public class PLayerController : MonoBehaviour {

	public float moveSpeed;
	private float moveVelocity;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;


	bool doubleJumped;


	// Use this for initialization
	void Start () {
	
	}


	void FixedUpdate(){
	
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	
	
	}

	//controls how user makes the player move
	// Update is called once per frame
	void Update () {
	
		moveVelocity = 0f;

		if (grounded) {
		
			doubleJumped = false;
		}

		if (Input.GetKeyDown (KeyCode.W) && grounded) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

		}

		if (Input.GetKeyDown (KeyCode.W) && !doubleJumped && !grounded) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			doubleJumped = true;
		}

		if (Input.GetKey (KeyCode.D)) {

			//GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
		}

		if (Input.GetKey (KeyCode.A)) {

			//GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = - moveSpeed;

		}


		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

	}
}
