using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	private Transform t;
	// Use this for initialization
	void Start () {
		
		t = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			t.rotation = Quaternion.Euler (0,0,90);
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			t.rotation = Quaternion.Euler (0,0,-90);
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			t.rotation = Quaternion.Euler (0,0,180);
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			t.rotation = Quaternion.Euler (0,0,0);
		}

	}
}
