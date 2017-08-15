using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : BasicStats {
	public  float mH;
	// Use this for initialization
	void Start () {
		maxHealth = mH;
		print ("Hi");
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead ()) {
			print ("Enemy is dead");
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		print ("Enemy Hit");
		takeDamage (10.0f);
	}
}
