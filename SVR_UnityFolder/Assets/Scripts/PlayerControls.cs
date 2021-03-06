﻿using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
	public int playerIndex = 0;

	public float xMoveScale = 1.0f;
	public float yMoveScale = 1.0f;

	bool canJump = true;

	Rigidbody2D playerRigidbody;

	// Use this for initialization
	void Start () 
	{
		playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float xForce = 0;
		float yForce = 0;


		if(playerIndex == 0)
		{
			if(Input.GetKey(KeyCode.A))
				xForce -= xMoveScale;
			if(Input.GetKey(KeyCode.D))
				xForce += xMoveScale;
			if(Input.GetKeyDown(KeyCode.W))
				yForce += yMoveScale;
		}
		
		if(playerIndex == 1)
		{

			if(Input.GetKey(KeyCode.LeftArrow))
				xForce -= xMoveScale;
			if(Input.GetKey(KeyCode.RightArrow))
				xForce += xMoveScale;
			if(Input.GetKeyDown(KeyCode.UpArrow))
				yForce += yMoveScale;
		}

		if(canJump == false)
			yForce = 0;

		if(yForce != 0)
			canJump = false;

		playerRigidbody.AddForce(new Vector2(0, yForce));
		transform.Translate(new Vector3(xForce * Time.deltaTime , 0, 0), Space.World);

	}


	void OnCollisionEnter2D(Collision2D coll) 
	{
		if(coll.gameObject.tag == "Floor")
			canJump = true;
	}
}
