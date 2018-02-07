using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItems : MonoBehaviour {

	// Use this for initialization
	public AudioClip clip;
	AudioSource source;
	void Start () {
		source = GetComponent<AudioSource>();  
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 90* Time.deltaTime ,0);
	}

	private void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "Player"){
			source.PlayOneShot(clip, 0.7f);
			Destroy(gameObject);
		}
	}
}
