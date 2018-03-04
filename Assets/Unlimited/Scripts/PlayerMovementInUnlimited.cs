using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementInUnlimited : MonoBehaviour {
	private int speed = 20 ;
	bool Right;
	bool Left;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		

		if(transform.position.y<-1){
			FindObjectOfType<GameManager>().EndGame();
		}

		if(Right){
			Debug.Log("right");
			GetComponent<Rigidbody>().AddForce(50 * Time.deltaTime,0,0, ForceMode.Impulse);
		}

		if(Left){
			GetComponent<Rigidbody>().AddForce(-50 * Time.deltaTime,0,0, ForceMode.Impulse);
		}

		 GetComponent<Rigidbody>().AddForce(0,0, speed*Time.deltaTime, ForceMode.Impulse);
	}

	public void onRightDown(bool down){
		Right = down;
	}

	public void OnLeftDown(bool down){
		Left = down;
	}

}
