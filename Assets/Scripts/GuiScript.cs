using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	public void OnGUI() {
		if(gameObject.GetComponent<WeaponScript>() != null)
			GUI.Label(new Rect(0,0,200,20), "Weapon: " + gameObject.GetComponent<WeaponScript>().weaponName);
		
		GUI.Label(new Rect(0,20,200,20), "Time: " + Time.realtimeSinceStartup);
	}
}
