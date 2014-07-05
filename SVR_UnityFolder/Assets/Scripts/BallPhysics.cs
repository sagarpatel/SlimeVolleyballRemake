using UnityEngine;
using System.Collections;

public class BallPhysics : MonoBehaviour 
{

	public float gravityScale = 1.0f;

	Rigidbody2D ballRigidBody;


	// Use this for initialization
	void Start () 
	{
		ballRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		ballRigidBody.AddForce(new Vector2(0, -gravityScale) );
	
	}


}
