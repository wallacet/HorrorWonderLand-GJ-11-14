using UnityEngine;
using System.Collections;

public class ZombieGenerator : MonoBehaviour {

	public GameObject Zombie;
	private float currentTime;
	private bool zombieSpawned;
	// Use this for initialization
	void Start () {
		currentTime = Time.realtimeSinceStartup;
	}



	// Update is called once per frame
	void Update () {

		if (((int)(Time.realtimeSinceStartup - currentTime) % 10) == 0) {
						if (!zombieSpawned) {
								Instantiate (Zombie, transform.position, Quaternion.identity);
								zombieSpawned = true;
						}
				} else {
			zombieSpawned = false;
				}
	}
}
