using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
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
		if(Input.GetKeyDown(KeyCode.A))
			xForce -= xMoveScale * Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.D))
			xForce += xMoveScale * Time.deltaTime;

		if(Input.GetKeyDown(KeyCode.S))
			yForce -= yMoveScale * Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.W))
			yForce += yMoveScale * Time.deltaTime;


		print(xForce);

		playerRigidbody.AddForce(new Vector3(xForce, yForce, 0));


	}
}
