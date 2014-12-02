using UnityEngine;
using System.Collections;

public class PlayerInteractions : MonoBehaviour {

	public GameObject player;
	public GameObject defender;
	public GameObject creep;


	public GUIText healthText;
	private int health;

	// Initialize player health and display it
	void Start(){
		health = 20;
		healthText.text = "Health: " + health.ToString ();
	}

	// Instantiate a defender in front of the player
	void PlaceDefender (){
		Vector3 playerPos = player.transform.position + player.transform.forward;
		Instantiate (defender, playerPos, Quaternion.identity);

	}
	
	// If creep collides with player, player loses health and creep is destroyed
	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Creep(Clone)"){
			health = health - 1;
			healthText.text = "Health: " + health.ToString ();
			GameObject.Destroy (other.gameObject);		
		}
	}
	
	// If player presses "Place", a defender is placed in front of him
	// If player runs out of health, quit the application
	void Update () {
		if (Input.GetButton ("Place")){
			PlaceDefender();
		}
		if (health <= 0){
			Application.Quit();
		}
	}
}
