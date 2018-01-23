using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour {

	
	bool Right;
	bool Left;

	bool Forward;
	bool Backward;

	// Use this for initialization
	void Start () {
		// rigidbody.useGravity = true;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	
		if(transform.position.y<-1){
			FindObjectOfType<GameManager>().EndGame();
		}

		if(Right){
			GetComponent<Rigidbody>().AddForce(50 * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}

		if(Left){
			GetComponent<Rigidbody>().AddForce(-50 * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}

		if(Forward){
			GetComponent<Rigidbody>().AddForce(0,0,50* Time.deltaTime, ForceMode.VelocityChange);
		}

		if(Backward){
			GetComponent<Rigidbody>().AddForce(0,0,-50* Time.deltaTime, ForceMode.VelocityChange);
		}
		
	}

	public void onRightDown(bool down){
		Right = down;
	}

	public void OnLeftDown(bool down){
		Left = down;
	}

	public void OnForwardDown(bool down){
		Forward = down;
	}

	public void OnBackwardDown(bool down){
		Backward = down;
	}

}
