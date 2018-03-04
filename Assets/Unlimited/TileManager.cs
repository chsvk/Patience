using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

	public GameObject[] tiles;
	private Transform player;
	private float SpawnLocationZ = -30.0f;
	private float tileLength = 36;
	private float amountOfTilesOnScreen = 5;
	private float SafeZone = 45;
	private List<GameObject> activeTiles;
	private int lastPrefabIndex = 0;
	private bool StartCompleted = false;
	// Use this for initialization
	void Start () {
		activeTiles = new List<GameObject>();
		player = GameObject.FindGameObjectWithTag("Player").transform;
		for(int i =0; i<amountOfTilesOnScreen; i++){
			Debug.Log("Start Method");
			SpawnTile(-1);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if((player.transform.position.z -SafeZone > (SpawnLocationZ - amountOfTilesOnScreen * tileLength))){
			// Debug.Log("started");
			SpawnTile(0);
			DeleteTile();
		}
	}

	void SpawnTile( int prefabIndex){
		if(prefabIndex == -1){
			GameObject gor;
			gor = Instantiate(tiles[0]) as GameObject;
			gor.transform.SetParent(transform);
			gor.transform.position = Vector3.forward * SpawnLocationZ;
			SpawnLocationZ += tileLength;
			activeTiles.Add(gor);
		}else{
		GameObject go;
		go = Instantiate(tiles[Randome()]) as GameObject;
		go.transform.SetParent(transform);
		go.transform.position = Vector3.forward * SpawnLocationZ;
		SpawnLocationZ += tileLength;
		activeTiles.Add(go);
		}
	}

	void DeleteTile(){
		Destroy(activeTiles[0]);
		activeTiles.RemoveAt(0);
	}

    private int Randome(){
		if(tiles.Length <=1){
			return 0;
		}
		int randomIndex = lastPrefabIndex;
		while(randomIndex == lastPrefabIndex){
			randomIndex = Random.Range(0, tiles.Length);
		}
		lastPrefabIndex = randomIndex;
		return randomIndex;
	}
}
