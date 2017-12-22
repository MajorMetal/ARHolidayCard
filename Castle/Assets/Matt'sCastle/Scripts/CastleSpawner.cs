using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSpawner : MonoBehaviour {

	 public GameObject castlePrefab;
	 public Transform targetPos;
	 GameObject spawnedCastle;
	 public List <GameObject> castles = new List<GameObject> ();
	 public int castleIndex = 0;


	void Start()
	{
		
	}

	void Update ()
	{
	
	}

	public void SpawnCastle () { 
		if (spawnedCastle != null)
		{
			Destroy (spawnedCastle);
		}
		spawnedCastle = Instantiate (castles[castleIndex], targetPos.position, targetPos.rotation) as GameObject;
		spawnedCastle.SetActive (true);

	}

	public void NextCastle (){
		castleIndex++;
		if (castleIndex >= castles.Count)
		{
			castleIndex = 0;
		}
		SpawnCastle ();

	}
	public void PrevCastle(){
		castleIndex--;
		if (castleIndex >= castles.Count)
		{
			castleIndex = 1;
		}
		SpawnCastle ();
	}
}
