using UnityEngine;
using System.Collections;

public class PlayerWeaponScript : MonoBehaviour {

	private WeaponScript currentWeapon;
	
	// Update is called once per frame
	public void Update () {
		if(currentWeapon != null) {
			if(Input.GetButtonDown("attack"))
				currentWeapon.Use();
		}
	}

	public void EquipWeapon(WeaponScript weapon) {
		if(currentWeapon != null)
			Destroy(currentWeapon);

		currentWeapon = gameObject.AddComponent(weapon.GetType().ToString()) as WeaponScript;
		currentWeapon.projectile = weapon.projectile;
	}
}
