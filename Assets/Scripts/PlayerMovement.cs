using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	private Transform t;
	private Vector3 mov;
	// Use this for initialization
	void Start () {
		t = this.gameObject.transform;
		mov = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W)) {
			mov = Vector3.up * speed;
		}
		else if (Input.GetKey (KeyCode.S)) {
			mov = Vector3.up * (-1 * speed);
		}
		else if (Input.GetKey (KeyCode.A)) {
			mov = Vector3.right * (-1 * speed);
		}
		else if (Input.GetKey (KeyCode.D)) {
			mov = Vector3.right * speed;
		}
		t.position += mov;
		mov = Vector3.zero;
	}
}
