using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour {

	public GameObject crackedVersion;
	public PlayerMovement movement;

	// Use this for initialization
	private void OnCollisionEnter(Collision other) {
		
		if(other.collider.tag == "Obstacle"){
			movement.enabled = false;
			Destroy(gameObject);
			Instantiate(crackedVersion, transform.position, transform.rotation);
			FindObjectOfType<GameManager>().EndGame();
		}

		if(other.collider.tag == "LevelComplete"){
			movement.enabled = false;
			Debug.Log("Level Complete");
			FindObjectOfType<GameManager>().LevelComplete();
		}
	}
}
