using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject obj;
	
	void Start () {
		Spawn ();
	}

	void Spawn()
	{
		Instantiate (obj, new Vector2(transform.position.x, Random.Range (-5.5f,5.5f)), Quaternion.identity);
		Invoke ("Spawn", Random.Range (1, 4));
	}
}
