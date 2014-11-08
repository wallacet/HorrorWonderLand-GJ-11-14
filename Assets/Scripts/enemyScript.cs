using UnityEngine;
using System.Collections;

public abstract class enemyScript : MonoBehaviour {


	private int damage;

	public int Damage{
		get { return damage; }
		set { damage = value; }
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void useAbility() {

	}

}
