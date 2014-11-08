using UnityEngine;
using System.Collections;

public class ZombieAIScript : AiScript {

	private Vector2 position;

	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		Alerted ();
	}

	public override void Move ()
	{
		base.Move ();
		Debug.Log ("zombie move");
		Debug.Log ("position: " + this.gameObject.transform.position);
		Debug.Log ("move target: " + moveTarget);
		if(moveTarget.x < this.gameObject.transform.position.x)
		{
			this.gameObject.transform.position = new Vector2(
				( this.gameObject.transform.position.x - this.speed * Time.deltaTime), 
				this.gameObject.transform.position.y);
		}
		else
		{
			this.gameObject.transform.position = new Vector2(
				( this.gameObject.transform.position.x + this.speed * Time.deltaTime), 
				this.gameObject.transform.position.y);
		}
	}

	public override void Alerted ()
	{
		//Debug.Log ("alerted is called");
		base.Alerted ();
		if (isTriggered) 
		{
			Debug.Log ("trigger is ture");
			this.Move();
		}
	}

}
