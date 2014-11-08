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

	public void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("colliding");
		if (other.gameObject.tag == "Player") 
		{
			Debug.Log ("colliding with player");
			playerPosition = other.gameObject.transform.position;
			isTriggered = true;
		} 
		else 
		{
			isTriggered = false;
		}
	}

}
