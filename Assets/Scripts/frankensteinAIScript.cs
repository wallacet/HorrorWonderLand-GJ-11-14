using UnityEngine;
using System.Collections;

public class FrankensteinAIScript : AiScript {

	private GameObject player;
	private SpriteAnimationManagerScript sams;

	// Use this for initialization
	public override void Start () {
		base.Start ();
		player = GameObject.Find ("Player");
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
		base.Alerted ();
		if (isTriggered) 
		{
			this.Move();
		}
	}
}
