using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndGame(){
		Invoke("ResetParameters", 1f);
	}

	public void LevelComplete(){
		Invoke("LevelCompleted", 1f);
	}

	void ResetParameters(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	void LevelCompleted(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
