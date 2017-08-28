using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : BasicStats {
	public  float mH;
	// Use this for initialization
	void Start () {
		maxHealth = mH;
		currentHealth = mH;
	}

	// Update is called once per frame
	void Update () {
		if (isDead()) {
			print ("Dead");
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		takeDamage (10.0f);
		print (currentHealth + " " + isDead());
	}
}
