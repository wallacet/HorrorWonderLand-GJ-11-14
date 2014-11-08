using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Right") || Input.GetButton ("Left")) {
			if(gameObject.transform.position.x < 100 && gameObject.transform.position.y == 0){
				this.gameObject.transform.position = new Vector2((transform.position.x + 1), transform.position.y);
			}
			else if(gameObject.transform.position.x == 100 && gameObject.transform.position.y < 100){
				this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y +1);
			}
			else if(gameObject.transform.position.x > 0 && gameObject.transform.position.y == 100){
				this.gameObject.transform.position = new Vector2(transform.position.x-1, transform.position.y);
			}
			else if(gameObject.transform.position.x == 0 && gameObject.transform.position.y > 0){
				this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y-1);
			}
		}
	}
}
