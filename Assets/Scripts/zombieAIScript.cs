using UnityEngine;
using System.Collections;

public class ZombieAIScript : AiScript {

	private Vector2 position;

	// Use this for initialization
	public override void Start () {
		base.Start ();
		position = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		Alerted ();
	}

	public override void Move ()
	{
		base.Move ();
		if(moveTarget.x < position.x)
		{
			position = new Vector2(( position.x - this.speed * Time.deltaTime), position.y);
		}
		else
		{
			position = new Vector2(( position.x + this.speed * Time.deltaTime), position.y);
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
