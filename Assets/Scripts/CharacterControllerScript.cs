using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {
	SpriteAnimationManagerScript manager;
	public float speed = 2.0f;
	public float jumpHeight = 250.0f;
	public bool jumping = false;

	// Use this for initialization
	void Start () {
		manager = GetComponent<SpriteAnimationManagerScript> ();
		manager.PauseAnimation (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Right")) {
			this.gameObject.transform.position = 
				new Vector2 ((transform.position.x + speed * Time.deltaTime), transform.position.y);

			manager.PlayAnimation("WalkRight");
			manager.PauseAnimation(false);
		} 
		else if(Input.GetButtonUp("Right")){
			manager.PauseAnimation(true);
		}
		else if (Input.GetButton ("Left")) {
			this.gameObject.transform.position = 
				new Vector2 ((transform.position.x - speed * Time.deltaTime), transform.position.y);
		} 
		else if (Input.GetButton ("Jump")) {
			if(!jumping){
				rigidbody2D.AddForce(new Vector2(0, jumpHeight));
				jumping = true;
			}
		}
	}

	public void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Platform") {
			jumping = false;
		}
	}
}
