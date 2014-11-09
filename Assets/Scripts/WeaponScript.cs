using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	public GameObject projectile;
	public int damage;
	public float recoilAmount = 0;
	public float recoilLength = 0;
	public string weaponName = "None";

	// Use this for initialization
	public virtual void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}

	public virtual void Use() {
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

			temp.GetComponent<ProjectileScript>().damage = damage;
		}
		else
			Debug.LogWarning("No projectile set.");

		
		CameraShakeScript tmp = gameObject.GetComponent<CameraShakeScript>();
		tmp.shake = recoilLength;
		tmp.shakeAmount = recoilAmount;

		ScreenFlsahScript tmp2 = gameObject.GetComponent<ScreenFlsahScript>();
		tmp2.flashTime = recoilLength;
	}

}
