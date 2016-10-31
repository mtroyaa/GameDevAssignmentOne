//EnemyController.cs
//Michael Troya
//Controls Enemies


using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool isWall;

	private bool notAtEdge;
	public Transform edgeCheck;


	// Use this for initialization
	void Start () {
	
	}


	//moves the enemy side to side and also checks if there is a wall or there is no wall changing the enemies direction
	// Update is called once per frame
	void Update () {

		isWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);

		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, wallCheckRadius, whatIsWall);

		if (isWall || !notAtEdge)
			moveRight = !moveRight;

		if (moveRight) {

			transform.localScale = new Vector3 (-1f, 1f, 1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		
		} else {

			transform.localScale = new Vector3 (1f, 1f, 1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}


	}
}
