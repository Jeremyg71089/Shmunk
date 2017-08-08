using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	private Transform t;
	private Vector3 mov;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		t = this.gameObject.transform;
		mov = Vector3.zero;
		rb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = Vector2.zero;
		if (Input.GetKey (KeyCode.W)) {
			rb.velocity = Vector2.up * speed;
			//mov = Vector3.up * speed;
		}
		else if (Input.GetKey (KeyCode.S)) {
			rb.velocity = Vector2.down * speed;
			//mov = Vector3.up * (-1 * speed);
		}
		else if (Input.GetKey (KeyCode.A)) {
			rb.velocity = Vector2.left * speed;
			//mov = Vector3.right * (-1 * speed);
		}
		else if (Input.GetKey (KeyCode.D)) {
			rb.velocity = Vector2.right * speed;
			//mov = Vector3.right * speed;
		}

		/*t.position += mov;
		mov = Vector3.zero;*/
	}
}
