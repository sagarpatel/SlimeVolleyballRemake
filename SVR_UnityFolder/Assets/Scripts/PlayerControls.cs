using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
	public int playerIndex = 0;

	public float xMoveScale = 1.0f;
	public float yMoveScale = 1.0f;

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
			if(Input.GetKeyDown(KeyCode.A))
				xForce -= xMoveScale * Time.deltaTime;
			if(Input.GetKeyDown(KeyCode.D))
				xForce += xMoveScale * Time.deltaTime;

			if(Input.GetKeyDown(KeyCode.W))
				yForce += yMoveScale * Time.deltaTime;
		}
		
		if(playerIndex == 1)
		{

			if(Input.GetKeyDown(KeyCode.LeftArrow))
				xForce -= xMoveScale * Time.deltaTime;
			if(Input.GetKeyDown(KeyCode.RightArrow))
				xForce += xMoveScale * Time.deltaTime;


			if(Input.GetKeyDown(KeyCode.UpArrow))
				yForce += yMoveScale * Time.deltaTime;



		}


		print(xForce);

		playerRigidbody.AddForce(new Vector3(xForce, yForce, 0));


	}
}
