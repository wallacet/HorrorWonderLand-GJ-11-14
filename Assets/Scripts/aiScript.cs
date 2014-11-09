using UnityEngine;
using System.Collections;

public class AiScript : MonoBehaviour {

	public float speed;
	public GameObject triggerVolume;
	protected bool isTriggered {
		get{
			return triggerVolume.GetComponent<TriggerVolumeScript>().isTriggered;
		}
	}

	// Use this for initialization
	public virtual void Start () {
	}
	
	// Update is called once per frame
	public virtual void Update () {
	
	}

	public virtual void Move(){

	}

	public virtual void Alerted(){
	}

}
