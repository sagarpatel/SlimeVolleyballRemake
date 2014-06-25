using UnityEngine;
using System.Collections;

public class BallLogic : MonoBehaviour 
{

	public Vector3 ballSpawnPosition;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	 void OnCollisionEnter2D(Collision2D coll) 
	 {
	 	if(coll.gameObject.tag == "Floor")
	 	{
	 		rigidbody2D.velocity = Vector3.zero;
			rigidbody2D.angularVelocity = 0;
	 		transform.position = ballSpawnPosition;
	 	}
	 }
}
