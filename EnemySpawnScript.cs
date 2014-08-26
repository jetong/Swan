using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour {
	public float minSpawnDelay;
	public float maxSpawnDelay;
	public GameObject[] obj;
	
	void Start () {
		Spawn ();
	}

	void Spawn()
	{
		//randomize the enemy object to spawn
		int randomIndex = (int) Mathf.Round (Random.Range( 0, obj.Length));
		Instantiate (obj[randomIndex], new Vector2(transform.position.x, Random.Range (-5.5f,5.5f)), Quaternion.identity);
		Invoke ("Spawn", Random.Range (minSpawnDelay, maxSpawnDelay));
	}
}
