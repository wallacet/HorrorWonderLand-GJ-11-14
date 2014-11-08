using UnityEngine;
using System.Collections;

public abstract class HealthScript : MonoBehaviour {
	public float health = 10.0f;

	public void Damage(float damage) {
		health -= damage;
	}

	public abstract void Die();
	
	// Update is called once per frame
	public void Update () {
		if(health <= 0)
			Die();
	}
}
