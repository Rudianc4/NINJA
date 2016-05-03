using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private PlayerController player;

	public GameObject deathParticle;
	public GameObject respawnParticle;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		 

	}
	public void RespawnPlayer (){
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		Debug.Log("player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		Instantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
	}
}
