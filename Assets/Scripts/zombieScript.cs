using UnityEngine;
using System.Collections;

public class ZombieScript : EnemyScript {

	// Use this for initialization
	public override void Start () {
		base.Start ();
		damage = 3;
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	}
}
