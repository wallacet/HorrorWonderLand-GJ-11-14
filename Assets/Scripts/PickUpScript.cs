using UnityEngine;
using System.Collections;

[RequireComponent(typeof(WeaponScript))]
public class PickUpScript : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") {
			other.gameObject.GetComponent<PlayerWeaponScript>().EquipWeapon(gameObject.GetComponent<WeaponScript>());
			this.enabled = false;
		}
	}
}
