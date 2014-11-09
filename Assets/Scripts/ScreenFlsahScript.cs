using UnityEngine;
using System.Collections;

public class ScreenFlsahScript : MonoBehaviour {

	public float flashTime = 0;
	public float flashPeriod = 20;

	private GUITexture flash;
	
	// Use this for initialization
	void Start () {
		Texture2D texture;
		GameObject storageGB;

		texture = new Texture2D(1,1);
		texture.SetPixel(0,0, Color.white);

		storageGB = new GameObject("Flash");
		storageGB.transform.localScale = new Vector3(0 , 0 , 1);
		
		flash = storageGB.AddComponent<GUITexture>();
		flash.pixelInset = new Rect(0 , 0 , Screen.width , Screen.height );
		flash.color = Color.white;
		flash.texture = texture;
		flash.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(flashTime <= 0) {
			flashTime = 0;
			flash.enabled = false;
			return;
		}

		if(Mathf.Sin(flashTime * flashPeriod + Mathf.PI / 2.0f) > 0) {
			flash.enabled = true;
		}
		else {
			flash.enabled = false;
		}

		flashTime -= Time.deltaTime;
	}
}
