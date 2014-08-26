using UnityEngine;
using System.Collections;

public class displayScript : MonoBehaviour {
	public GUIText scoreText;
	private float score = 0;
	private PlayerControllerScript playerController;
	
	void Start () {
		playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerScript>();
		scoreText.text = "";
	}
	
	void Update () {
		if(playerController.playerAlive){
			score += Time.time;
		}
		scoreText.text = "Score: " + (int)score/10;
	}
}
