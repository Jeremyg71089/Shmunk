using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	private Transform t;
	public GameObject laserPrefab;
	public float laserSpeed;
	public Transform laserSpawn;
	public float rateOfFire;
	private bool canFire;
	float timeSinceLastFire;
	void Start () {
		t = this.gameObject.transform;
		canFire = true;
		timeSinceLastFire = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			t.rotation = Quaternion.Euler (0, 0, 90);
			if (canFire) {
				fire (Vector2.left);
				canFire = false;
			}
		} 
		else if (Input.GetKey (KeyCode.RightArrow)) {
			t.rotation = Quaternion.Euler (0, 0, -90);
			if (canFire) {
				fire (Vector2.right);
				canFire = false;
			}
		} 
		else if (Input.GetKey (KeyCode.DownArrow)) {
			t.rotation = Quaternion.Euler (0, 0, 180);
			if (canFire) {
				fire (Vector2.down);
				canFire = false;
			}
		} 
		else if (Input.GetKey (KeyCode.UpArrow)) {
			t.rotation = Quaternion.Euler (0, 0, 0);
			if (canFire) {
				fire (Vector2.up);
				canFire = false;
			}
		}
		if (!canFire) {
			timeSinceLastFire += Time.deltaTime;
			if (timeSinceLastFire > (5.0f / rateOfFire)) {
				canFire = true;
				timeSinceLastFire = 0;
			}
			print (timeSinceLastFire);
		}
	}

	void fire(Vector2 v){
		GameObject laser = GameObject.Instantiate (laserPrefab,laserSpawn.position,laserSpawn.rotation);
		laser.GetComponent<Rigidbody2D> ().velocity = v * laserSpeed;
	}
}
