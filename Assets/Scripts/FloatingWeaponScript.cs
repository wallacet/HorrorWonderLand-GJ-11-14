using UnityEngine;
using System.Collections;

public class FloatingWeaponScript : MonoBehaviour {

	public float amplitude = 0.2f;
	public float period = 1;
	private float originalY;

	void Start() {
		originalY = transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, originalY + amplitude * Mathf.Sin(period * Time.realtimeSinceStartup), 0);
	}
}
