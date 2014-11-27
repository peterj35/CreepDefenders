using UnityEngine;
using System.Collections;

public class PlayerInteractions : MonoBehaviour {

	public GameObject player;
	public GameObject defender;
	public GameObject creep;


	public GUIText healthText;
	private int health;

	void Start(){
		health = 20;
		healthText.text = "Health: " + health.ToString ();
	}

	void PlaceDefender (){
		Vector3 playerPos = player.transform.position + player.transform.forward;
		Instantiate (defender, playerPos, Quaternion.identity);

	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Creep(Clone)"){
			health = health - 1;
			healthText.text = "Health: " + health.ToString ();
			GameObject.Destroy (other.gameObject);		
		}
	}
	
	void Update () {
		if (Input.GetButton ("Place")){
			PlaceDefender();
		}
		if (health <= 0){
			Application.Quit();
		}
	}
}
