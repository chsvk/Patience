using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform playerTransform;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
		offset.x = 0;
		offset.y = 1f;
		offset.z = -3.5f;
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Transform>().position = playerTransform.position + offset;
		
	}
}
