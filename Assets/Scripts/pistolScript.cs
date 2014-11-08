using UnityEngine;
using System.Collections;

public class PistolScript : WeaponScript {

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
		if(projectile != null) {
			Vector3 spawnPoint = gameObject.transform.position;
			if(GetComponent<CharacterControllerScript>().facingLeft){
				spawnPoint -= new Vector3(projectile.GetComponent<ProjectileScript>().width / 2.0f
				                          + gameObject.GetComponent<BoxCollider2D>().size.x / 2.0f + 0.1f,
				                          0,0);
			}
			else{
				spawnPoint += new Vector3(projectile.GetComponent<ProjectileScript>().width / 2.0f
				                          + gameObject.GetComponent<BoxCollider2D>().size.x / 2.0f + 0.1f,
				                          0,0);
			}
			GameObject temp = Instantiate(projectile, spawnPoint, Quaternion.identity) as GameObject;

			if(gameObject.GetComponent<CharacterControllerScript>().facingLeft){
				temp.GetComponent<ProjectileScript>().velocity *= -1;
			}
		}
		else
			Debug.LogWarning("No projectile set.");
	}
}
