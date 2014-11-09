using UnityEngine;
using System.Collections;

public class ZombieAIScript : AiScript {

	private GameObject player;
	private SpriteAnimationManagerScript sams;

	// Use this for initialization
	public override void Start () {
		base.Start ();
		player = GameObject.Find("Main Character");
		sams = gameObject.GetComponent<SpriteAnimationManagerScript>();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		Alerted ();
	}

	public override void Move ()
	{
		if(player.transform.position.x > gameObject.transform.position.x) {
			transform.position += new Vector3(speed * Time.deltaTime,0,0);
			sams.PlayAnimation("WalkRight");
		}
		else {
			transform.position -= new Vector3(speed * Time.deltaTime,0,0);
			sams.PlayAnimation("WalkLeft");
		}

	}

	public override void Alerted ()
	{
		//Debug.Log ("alerted is called");
		base.Alerted ();
		if (isTriggered) 
		{
			this.Move();
		}
	}

}
