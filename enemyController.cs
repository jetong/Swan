using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {
	public float verticalSpeed;
	public float horizontalSpeed;
	public float minDelay;	
	public float maxDelay;
	public bool enemyAlive;
	

	private GameObject player;
	private Transform rock;
	private float nextMove;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

		rock = transform.FindChild( "Rock" );
		if( rock != null ){
			rock.gameObject.SetActive( true );
		}
	}

	void Update () {
		if(enemyAlive && Time.time > nextMove){
			Maneuver();
			if(rock != null && player.transform.position.x >= transform.position.x){
				releaseRock ();
			}
		}
	}


	public void releaseRock() {
//		Instantiate (rock, rock.transform.position, rock.transform.rotation);
//		rock.rigidbody2D.velocity = new Vector2 (-horizontalSpeed, -1);
	}

	public void Maneuver(){
		Vector2 direction = new Vector2(-horizontalSpeed, Random.Range (-1f,1f));
		rigidbody2D.velocity = direction * verticalSpeed;
		nextMove = Random.Range(minDelay, maxDelay) + Time.time;
	}
}