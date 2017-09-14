using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAttack : MonoBehaviour {
	public float timeBetweenShots;
	public GameObject bulletPrefab;
	private float timeSinceLastFire;
	public GameObject target;
	public float bulletspeed;
	// Use this for initialization
	void Start () {
		timeSinceLastFire = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeSinceLastFire < timeBetweenShots) {
			timeSinceLastFire += Time.deltaTime;
		} 
		else {
			fire ();
			timeSinceLastFire = 0;
		}
	}

	void fire() {
		GameObject bullet = GameObject.Instantiate (bulletPrefab,gameObject.transform.position, 
			gameObject.transform.rotation);
		//bullet.transform.LookAt(target.transform);
		print(target.transform.position.x + " " + target.transform.position.y);
		bullet.GetComponent<Rigidbody2D> ().velocity = (bullet.transform.forward.normalized) *bulletspeed;
	}
}
