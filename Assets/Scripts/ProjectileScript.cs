using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

	public Vector2 velocity = new Vector2(0,0);
	public float gravity = 0;
	public float damage = 0;
	
	// Update is called once per frame
	public void Update () {
		gameObject.transform.position += new Vector3(velocity.x * Time.deltaTime, velocity.y * Time.deltaTime, 0);

		velocity = new Vector2(velocity.x, velocity.y - gravity * Time.deltaTime);
	}

	public void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Hitable"){
			other.gameObject.GetComponent<HealthScript>().Damage(damage);
		}
		Destroy(gameObject);
	}
}
