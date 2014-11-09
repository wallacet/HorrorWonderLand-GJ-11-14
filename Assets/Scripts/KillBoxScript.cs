using UnityEngine;
using System.Collections;

public class KillBoxScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D (Collider2D other) {
		if(other.gameObject.tag == "Player" || other.gameObject.layer == LayerMask.NameToLayer("Dead")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
