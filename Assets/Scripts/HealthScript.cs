using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteAnimationManagerScript))]
public class HealthScript : MonoBehaviour {
	public float health = 10.0f;
	public bool dead = false;

	public void Damage(float damage) {
		health -= damage;
	}

	public virtual void Die() { 
		if(LayerMask.NameToLayer("Enemy") == gameObject.layer) {
			GameObject.Find("Main Character").GetComponent<EnemyCounterScript>().enemyCount--;
			GetComponent<AiScript>().enabled = false;
		}
		else {
			foreach(BoxCollider2D box in gameObject.GetComponents<BoxCollider2D>())
				box.enabled=false;
		}

		gameObject.GetComponent<SpriteAnimationManagerScript>().PlayAnimation("Death");
		gameObject.layer = LayerMask.NameToLayer("Dead");
	}
	
	// Update is called once per frame
	public void Update () {
		if(health <= 0 && !dead) {
			Die();
			dead = true;
		}
	}
}
