using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {
	public float verticalSpeed;
	public float horizontalSpeed;
	public bool playerAlive;
	public AudioClip deathcry;

	void Update () {
		if(playerAlive)
		{
			float moveVertical = Input.GetAxis ("Vertical");
			float moveHorizontal = Input.GetAxis ("Horizontal");
			rigidbody2D.velocity = new Vector2 (moveHorizontal * horizontalSpeed, moveVertical * verticalSpeed);

			//make sure player can't leave screen
			rigidbody2D.position = new Vector2 (Mathf.Clamp (rigidbody2D.position.x, -4f, 14f), 
			                                    Mathf.Clamp (rigidbody2D.position.y, -5.5f, 5.5f));
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			playerAlive = false;
			AudioSource.PlayClipAtPoint(deathcry, transform.position);
			transform.Rotate (0,0,180);
			rigidbody2D.velocity = new Vector2(0, -10);

			other.gameObject.GetComponent<enemyController>().enemyAlive = false;
			other.transform.Rotate (0,0,180);
			other.rigidbody2D.velocity = new Vector2(0, -10);
		}
	}
}
