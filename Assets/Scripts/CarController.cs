using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	private bool move = false;
	public Rigidbody2D rigidbody2DCar;
	public float speed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		move = Input.GetButton("Fire1");
	}

	void FixedUpdate(){
		
		if(move){
			rigidbody2DCar.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
		}
	}
}
