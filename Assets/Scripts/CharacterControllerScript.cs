using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {
	SpriteAnimationManagerScript manager;
	public float speed = 2.0f;
	// Use this for initialization
	void Start () {
		manager = GetComponent<SpriteAnimationManagerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Right")) {
			this.gameObject.transform.position = new Vector2 ((transform.position.x + speed * Time.deltaTime), transform.position.y);
			manager.PlayAnimation("WalkRight");
		} 
		else if (Input.GetButton ("Left")) {
			this.gameObject.transform.position = new Vector2 ((transform.position.x - speed * Time.deltaTime), transform.position.y);
		} 
		else if (Input.GetButton ("Jump")) {
			this.gameObject.transform.position = new Vector2 ((transform.position.x), transform.position.y + speed * Time.deltaTime);
		}
	}
}
