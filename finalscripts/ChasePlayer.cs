using UnityEngine;
using System.Collections;

public class ChasePlayer : MonoBehaviour {
	
	private GameObject player;

	void Update () {
		player = GameObject.FindWithTag ("Player");		
		transform.LookAt (player.transform);
	}
}
