using UnityEngine;
using System.Collections;

public class MoveCreep : MonoBehaviour {

	public float speed;

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
