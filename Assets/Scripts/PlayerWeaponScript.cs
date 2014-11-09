using UnityEngine;
using System.Collections;

public class PlayerWeaponScript : MonoBehaviour {

	private WeaponScript currentWeapon;

	public void Start() {
		currentWeapon = gameObject.GetComponent<WeaponScript>();
	}
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
		currentWeapon.damage = weapon.damage;
		currentWeapon.recoilAmount = weapon.recoilAmount;
		currentWeapon.recoilLength = weapon.recoilLength;
		currentWeapon.weaponName = weapon.weaponName;
	}
}
