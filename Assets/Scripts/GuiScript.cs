using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	public void OnGUI() {
		if(gameObject.GetComponent<WeaponScript>() != null)
			GUI.Label(new Rect(0,0,200,20), "Weapon: " + gameObject.GetComponent<WeaponScript>().weaponName);
		
		GUI.Label(new Rect(0,20,200,20), "Time: " + Time.realtimeSinceStartup);
		GUI.Label(new Rect(0,40,200,20), "Enemies: " + gameObject.GetComponent<EnemyCounterScript>().enemyCount);

		if(GUI.Button(new Rect(200,0,100,20), "Reload Level"))
			Application.LoadLevel(Application.loadedLevel);
		if(GUI.Button(new Rect(200,20,100,20), "Level 1"))
			Application.LoadLevel(0);
		if(GUI.Button(new Rect(200,40,100,20), "Level 2"))
			Application.LoadLevel(1);
	}
}
