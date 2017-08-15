using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : BasicStats {


	private float shield;
	private float rateOfFire;

	// Use this for initialization
	void Start () {
		maxHealth = 100.0f;
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
