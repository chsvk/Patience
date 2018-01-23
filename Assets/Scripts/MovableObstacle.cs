using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObstacle : MonoBehaviour {

	public Material AfterTexture;
	bool hitOnce = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "Player" & (hitOnce == false)){
			Debug.Log("works");
			GetComponent<Renderer>().material = AfterTexture;
			hitOnce = true;
		}
		if(other.collider.tag == "Player" & (hitOnce)){
			GetComponent<MeshCollider>().enabled = false;
		}
	}
}
