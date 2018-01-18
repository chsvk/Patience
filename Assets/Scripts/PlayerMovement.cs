using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	 public Rigidbody rigidbody;
	 public Transform PlayerTransform;
	public Vector3 Start_Position;

	bool Right = false;

	// Use this for initialization
	void Start () {
		// rigidbody.useGravity = true;
		Start_Position.x = 0;
		Start_Position.y = 1;
		Start_Position.z = 4.18f;
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerTransform.position.y<-1){
			PlayerTransform.position = Start_Position;
		}

		if(Right){
			rigidbody.AddForce(100*Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
			
		}

		Right = false;
	}

	public void Move_Right(){
		Right = true;
		
	}

	public void Move_Left(){
		rigidbody.AddForce(-100*Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
	}

	public void Move_Forward(){
		rigidbody.AddForce(0, 0 , 100* Time.deltaTime, ForceMode.VelocityChange);
	}

	public void Move_BackWard(){
		rigidbody.AddForce(0, 0 , -100* Time.deltaTime, ForceMode.VelocityChange);
	}
}
