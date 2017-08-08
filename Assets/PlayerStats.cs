using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	private float health;
	private float shield;
	private float maxHealth;
	private float rateOfFire;

	// Use this for initialization
	void Start () {
		maxHealth = 100.0f;
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0.0f) {
			//destroy the ship, game over
		}
	}
}
