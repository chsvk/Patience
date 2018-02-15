using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

public GameObject circleGround;
public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RotateAround();
	}

	void RotateAround(){
		transform.RotateAround(circleGround.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
