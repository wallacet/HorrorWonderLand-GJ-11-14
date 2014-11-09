﻿using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {
	SpriteAnimationManagerScript manager;

	public float speed = 2.0f;
	public float jumpHeight = 250.0f;
	public bool jumping = false;
	public bool facingLeft = false;

	private bool applyForce = false;
	private int forceFrameDelay = 10;
	private int currentFramesDelay = 0;

	private bool grounded {
		get {
			RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y),
			                  -Vector2.up,
			                  gameObject.GetComponent<BoxCollider2D>().size.y/2.0f + 0.05f, LayerMask.GetMask("Ground", "Platform"));

			if(hit.collider != null) {
				return true;
			}
			else {
				return false;
			}
		}
	}

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
			facingLeft = false;
		} 
		else if(Input.GetButtonUp("Right")){
			manager.PlayAnimation("Idle");
		}
		else if (Input.GetButton ("Left")) {
			this.gameObject.transform.position = 
				new Vector2 ((transform.position.x - speed * Time.deltaTime), transform.position.y);

			manager.PlayAnimation("WalkLeft");
			manager.PauseAnimation(false);
			facingLeft = true;
		} 
		else if(Input.GetButtonUp("Left")){
			manager.PlayAnimation("Idle");
		}
		if (Input.GetButton ("Jump") && grounded) {
			if(!jumping && currentFramesDelay == 0){
				applyForce = true;
				jumping = true;
			}
		}
	}

	public void FixedUpdate() {
		if(applyForce) {
			currentFramesDelay = forceFrameDelay;
			rigidbody2D.AddForce(new Vector2(0, jumpHeight));
			applyForce = false;
		}
		if(currentFramesDelay > 0)
			currentFramesDelay--;
	}

	public void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Platform") {
			if(collider2D.bounds.min.y > other.collider.bounds.max.y) {
				jumping = false;
			}
		}
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Bumper") {
				applyForce = true;
				rigidbody2D.AddForce (new Vector2 (0, jumpHeight * 1.5f));
		}
	}
}
