using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform playerTransform;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
		offset.x = 0;
		offset.y = 2.8f;
		offset.z = -6.4f;
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Transform>().position = playerTransform.position + offset;
		
	}
}
