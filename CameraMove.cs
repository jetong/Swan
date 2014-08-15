using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float scrollSpeed;
	void Update () {
		rigidbody2D.velocity = new Vector2 (scrollSpeed, 0);
	}
}
