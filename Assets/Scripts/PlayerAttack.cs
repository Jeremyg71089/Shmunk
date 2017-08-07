using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	private Transform t;
	public GameObject laserprefab;
	public float laserspeed;
	public Transform laserspawn;
	// Use this for initialization
	void Start () {
		t = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			t.rotation = Quaternion.Euler (0,0,90);
			fire (Vector2.left);
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			t.rotation = Quaternion.Euler (0,0,-90);
			fire (Vector2.right);
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			t.rotation = Quaternion.Euler (0,0,180);
			fire (Vector2.down);
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			t.rotation = Quaternion.Euler (0,0,0);
			fire (Vector2.up);
		}

	}

	void fire(Vector2 v){
		GameObject laser = GameObject.Instantiate (laserprefab,laserspawn.position,laserspawn.rotation);
		laser.GetComponent<Rigidbody2D> ().velocity = v * laserspeed;
	}
}
