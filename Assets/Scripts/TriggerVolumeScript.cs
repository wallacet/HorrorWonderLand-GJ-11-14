using UnityEngine;
using System.Collections;

public class TriggerVolumeScript : MonoBehaviour {

	public bool isTriggered = false;
	public Vector2 playerPosition;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") 
		{
			playerPosition = other.gameObject.transform.position;
			isTriggered = true;
		}
	}

}
