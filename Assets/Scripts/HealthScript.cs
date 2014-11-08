using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {
	public float health = 10.0f;

	public void Damage(float damage) {
		health -= damage;
	}

	public virtual void Die() {
		Destroy(gameObject);
	}
	
	// Update is called once per frame
	public void Update () {
		if(health <= 0)
			Die();
	}
}
