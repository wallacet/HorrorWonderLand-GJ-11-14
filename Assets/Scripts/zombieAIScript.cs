using UnityEngine;
using System.Collections;

public class ZombieAIScript : AiScript {

	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	}

	public override void Move ()
	{
		base.Move ();
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
