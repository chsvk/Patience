using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
