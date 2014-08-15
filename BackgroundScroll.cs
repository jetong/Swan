using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {
	public float speed;
	public float pos = 0;

	void Start () {
	
	}

	void Update () {
		pos += speed;
		if(pos > 1.0f)
			pos -= 1.0f;

		renderer.material.mainTextureOffset = new Vector2 (pos, 0);
	}
}
