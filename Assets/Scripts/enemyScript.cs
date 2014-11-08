using UnityEngine;
using System.Collections;

public abstract class EnemyScript : MonoBehaviour {


	public int damage;

	// Use this for initialization
	public virtual void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}

	//might move this to AI script
	public virtual void useAbility() {

	}

}
