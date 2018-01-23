using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour {

	public PlayerMovement movement;

	// Use this for initialization
	private void OnCollisionEnter(Collision other) {
		
		if(other.collider.tag == "Obstacle"){
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}

		if(other.collider.tag == "LevelComplete"){
			movement.enabled = false;
			Debug.Log("Level Complete");
			FindObjectOfType<GameManager>().LevelComplete();
		}
	}
}
