using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	private bool isGrounded = false;
	private bool move = false;
	public Rigidbody2D rb2D;
	public float speed = 20f;
	public float rotationSpeed = 7f;

	void Update () {

		move = Input.GetButton("Fire1");
	}

	void FixedUpdate(){
		
		if(move){
			if(isGrounded)
			rb2D.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
			else
			rb2D.AddTorque(rotationSpeed * 2 * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
		}
	}

	void OnCollisionEnter2D(Collision2D collisionInfo){
		isGrounded = collisionInfo.transform.tag == "Ground";
	}

	void OnCollisionExit2D(Collision2D collisionInfo)
	{
		if(collisionInfo.transform.tag == "Ground")
		isGrounded = false;
	}
}
