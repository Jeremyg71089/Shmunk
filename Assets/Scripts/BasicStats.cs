using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStats : MonoBehaviour {

	protected float maxHealth;
	protected float currentHealth;
	private bool dead;
	// Use this for initialization
	void Start () {
		dead = false;
	}
		
	protected bool isDead(){
		return dead;
	}

	protected void takeDamage(float damage){

		currentHealth = currentHealth - damage;
		if (currentHealth <= 0) {
			dead = true;
		}
	}
}
