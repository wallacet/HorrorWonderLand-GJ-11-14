using UnityEngine;
using System.Collections;

public class ShotgunScript : WeaponScript {

	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	}

	public override void Use ()
	{
		base.Use ();
		Debug.Log("Shotgun Bang!");
	}
}
