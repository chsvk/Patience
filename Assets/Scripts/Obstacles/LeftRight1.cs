using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight1 : MonoBehaviour {

	// Use this for initialization
bool direction = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(direction){
			GetComponent<Rigidbody>().AddForce(-100* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}else{
			GetComponent<Rigidbody>().AddForce(100* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		
	}

	private void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "Move"){
			if(direction){
				direction = false;
			}else {
				direction = true;
			}
		}
	}
}
