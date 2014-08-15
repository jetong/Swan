using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {
	public float speed;
	public float minDelay;	
	public float maxDelay;
	public bool enemyAlive;

	private float nextMove;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(enemyAlive && Time.time > nextMove){
			Vector2 direction = new Vector2(0, Random.Range (-1f,1f));
			rigidbody2D.velocity = direction * speed;
			nextMove = Random.Range(minDelay, maxDelay) + Time.time;
		}
	}
}
