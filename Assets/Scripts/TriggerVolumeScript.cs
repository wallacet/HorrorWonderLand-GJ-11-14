using UnityEngine;
using System.Collections;

public class TriggerVolumeScript : MonoBehaviour {

	public bool isTriggered;
	public Vector2 playerPosition;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") 
		{
			isTriggered = true;
		} 
		else 
		{
			isTriggered = false;
		}
	}

}
