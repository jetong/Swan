using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {
	public float dodgeSpeed;
	public float scrollSpeed;
	public bool playerAlive;

	void Update () {
		if(playerAlive)
		{
				float moveVertical = Input.GetAxis ("Vertical");
				rigidbody2D.velocity = new Vector2 (scrollSpeed, moveVertical * dodgeSpeed);

				//clamp vertical position to top and bottom edges of screen.
				rigidbody2D.position = new Vector2 (rigidbody2D.position.x, Mathf.Clamp (rigidbody2D.position.y, -5.5f, 5.5f));
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			playerAlive = false;
			transform.Rotate (0,0,180);
			rigidbody2D.velocity = new Vector2(scrollSpeed, -10);

			other.gameObject.GetComponent<enemyController>().enemyAlive = false;
			other.transform.Rotate (0,0,180);
			other.rigidbody2D.velocity = new Vector2(0, -10);
		}
	}
}
